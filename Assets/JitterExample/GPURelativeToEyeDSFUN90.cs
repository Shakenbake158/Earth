using System;
using UnityEngine;
using System.Collections.Generic;
//using Earth.Renderer;
//using Earth.Core;
using Mesh = UnityEngine.Mesh;

public class GPURelativeToEyeDSFUN90 : MonoBehaviour
{
    private Earth.Renderer.SceneState _sceneState;
    
    private Earth.Scene.CameraLookAtPoint _lookCamera;
    private Earth.Scene.CameraFly _flyCamera;
    private Earth.Scene.GlobeClipmapTerrain _clipmap;
    private Earth.Scene.RayCastedGlobe _globe;
    private Earth.Core.Ellipsoid _ellipsoid;
    
    
    private MeshRenderer _meshRenderer;
    private MeshFilter _meshFilter;
    
    private bool _scaleWorldCoordinates;
    
    private double _xTranslation;

    private Material _planetShader;
    
    private Earth.Core.Vector3D _eye;
    
    private Earth.Core.Matrix4F _modelViewPerspectiveMatrixRelativeToEye;
    
    /*
    private void Awake()
    {
        _sceneState = new Earth.Renderer.SceneState();
        
        _planetShader = GetComponent<MeshRenderer>().materials[0];
        
        _xTranslation = FromMeters(Earth.Core.Ellipsoid.Wgs84.Radii.X);
        
        double triangleLength = FromMeters(200000);
        double triangleDelta = FromMeters(0.5);

        Earth.Core.Vector3D[] positions = new Earth.Core.Vector3D[]
        {
            new Earth.Core.Vector3D(_xTranslation, triangleDelta + 0, 0),                  // Red triangle
            new Earth.Core.Vector3D(_xTranslation, triangleDelta + triangleLength, 0),
            new Earth.Core.Vector3D(_xTranslation, triangleDelta + 0, triangleLength),
            new Earth.Core.Vector3D(_xTranslation, -triangleDelta - 0, 0),                 // Green triangle
            new Earth.Core.Vector3D(_xTranslation, -triangleDelta - 0, triangleLength),
            new Earth.Core.Vector3D(_xTranslation, -triangleDelta - triangleLength, 0),
            new Earth.Core.Vector3D(_xTranslation, 0, 0),                                  // Blue point
        };

        Color[] colors = new Color[]
        {
            new Color(1f, 0f, 0f),
            new Color(1f, 0f, 0f),
            new Color(0f, 1f, 0f),
            new Color(0f, 1f, 0f),
            new Color(0f, 0f, 1f),
            new Color(0f, 0f, 1f)
        };

        List<Vector3> highPositions = new List<Vector3>();
        List<Vector3> lowPositions = new List<Vector3>();
        List<Color> meshColors = new List<Color>();
        
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        
        for (int i = 0; i < positions.Length; i++)
        {
            Earth.Core.Vector3F positionHigh;
            Earth.Core.Vector3F positionLow;
            Vector3DToTwoVector3F(positions[i], out positionHigh, out positionLow);
            
            highPositions.Add(new Vector3(positionHigh.X, positionHigh.Y, positionHigh.Z));
            lowPositions.Add(new Vector3(positionLow.X, positionLow.Y, positionLow.Z));
        }

        mesh.vertices = highPositions.ToArray();
        mesh.normals = lowPositions.ToArray();
        mesh.colors = colors;
    }
    */

    private void Awake()
    {
        //_window = Device.CreateWindow(800, 600, "Chapter 13:  Clipmap Terrain on a Globe");

        _ellipsoid = Earth.Core.Ellipsoid.Wgs84;

        Earth.Scene.WorldWindTerrainSource terrainSource = new Earth.Scene.WorldWindTerrainSource();
        Earth.Scene.EsriRestImagery imagery = new Earth.Scene.EsriRestImagery();
        _clipmap = new Earth.Scene.GlobeClipmapTerrain(_window.Context, terrainSource, imagery, _ellipsoid, 511);
        _clipmap.HeightExaggeration = 1.0f;

        _sceneState = new Earth.Renderer.SceneState();
        _sceneState.DiffuseIntensity = 0.90f;
        _sceneState.SpecularIntensity = 0.05f;
        _sceneState.AmbientIntensity = 0.05f;
        _sceneState.Camera.FieldOfViewY = Math.PI / 3.0;

        _clearState = new Earth.Renderer.ClearState();
        _clearState.Color = UnityEngine.Color.white;

        _sceneState.Camera.PerspectiveNearPlaneDistance = 0.000001 * _ellipsoid.MaximumRadius;
        _sceneState.Camera.PerspectiveFarPlaneDistance = 10.0 * _ellipsoid.MaximumRadius;
        _sceneState.SunPosition = new Earth.Core.Vector3D(200000, 300000, 200000) * _ellipsoid.MaximumRadius;

        _lookCamera = new Earth.Scene.CameraLookAtPoint(_sceneState.Camera, _window, _ellipsoid);
        _lookCamera.Range = 1.5 * _ellipsoid.MaximumRadius;

        _globe = new Earth.Scene.RayCastedGlobe(_window.Context);
        _globe.Shape = _ellipsoid;
        Earth.Renderer.Texture2D bitmap = new Earth.Renderer.Texture2D("NE2_50M_SR_W_4096.jpg");
        _globe.Texture = Earth.Renderer.Device.CreateTexture2D(bitmap, TextureFormat.RedGreenBlue8, false);

        _clearDepth = new Earth.Renderer.ClearState();
        _clearDepth.Buffers = Earth.Renderer.ClearBuffers.DepthBuffer | Earth.Renderer.ClearBuffers.StencilBuffer;

        _window.Keyboard.KeyDown += OnKeyDown;

        _window.Resize += OnResize;
        _window.RenderFrame += OnRenderFrame;
        _window.PreRenderFrame += OnPreRenderFrame;

        _hudFont = new Font("Arial", 16);
        _hud = new HeadsUpDisplay();
        _hud.Color = Color.Blue;
        UpdateHUD();
    }

    private void Start()
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        Earth.Core.Vector3D eye = _sceneState.Camera.Eye;

        if (_eye != eye)
        {
            _eye = eye;

            Earth.Core.Vector3F eyeHigh;
            Earth.Core.Vector3F eyeLow;
            Vector3DToTwoVector3F(eye, out eyeHigh, out eyeLow);
            _planetShader.SetVector("u_cameraEyeHigh", new Vector3(eyeHigh.X, eyeHigh.Y, eyeHigh.Z));
            _planetShader.SetVector("u_cameraEyeLow", new Vector3(eyeLow.X, eyeLow.Y, eyeLow.Z));

            Earth.Core.Matrix4D m = _sceneState.ModelViewMatrix;
            Earth.Core.Matrix4D mv = new Earth.Core.Matrix4D(
                m.Column0Row0, m.Column1Row0, m.Column2Row0, 0.0,
                m.Column0Row1, m.Column1Row1, m.Column2Row1, 0.0,
                m.Column0Row2, m.Column1Row2, m.Column2Row2, 0.0,
                m.Column0Row3, m.Column1Row3, m.Column2Row3, m.Column3Row3);

            Matrix4x4 mat4x4 = Matrix4x4.zero;
            mat4x4.SetRow(0, new Vector4((float)m.Column0Row0, (float)m.Column1Row0, (float)m.Column2Row0, 0.0f));
            mat4x4.SetRow(1, new Vector4((float)m.Column0Row1, (float)m.Column1Row1, (float)m.Column2Row1, 0.0f));
            mat4x4.SetRow(2, new Vector4((float)m.Column0Row2, (float)m.Column1Row2, (float)m.Column2Row2, 0.0f));
            mat4x4.SetRow(3, new Vector4((float)m.Column0Row3, (float)m.Column1Row3, (float)m.Column2Row3, (float)m.Column3Row3));

            _planetShader.SetMatrix("u_modelViewPerspectiveMatrixRelativeToEye", mat4x4);
        }
        _planetShader.SetFloat("u_pointSize", (float)(8.0f * _sceneState.HighResolutionSnapScale));
    }
    
    private void DoubleToTwoFloats(double value, out float high, out float low)
    {
        high = (float)value;
        low = (float)(value - high);
    }
    
    private void Vector3DToTwoVector3F(Earth.Core.Vector3D value, out Earth.Core.Vector3F high, out Earth.Core.Vector3F low)
    {
        float highX;
        float highY;
        float highZ;

        float lowX;
        float lowY;
        float lowZ;

        DoubleToTwoFloats(value.X, out highX, out lowX);
        DoubleToTwoFloats(value.Y, out highY, out lowY);
        DoubleToTwoFloats(value.Z, out highZ, out lowZ);

        high = new Earth.Core.Vector3F(highX, highY, highZ);
        low = new Earth.Core.Vector3F(lowX, lowY, lowZ);
    }
    
    private double ToMeters(double value)
    {
        return _scaleWorldCoordinates ? (value * Earth.Core.Ellipsoid.Wgs84.MaximumRadius) : value;
    }

    private double FromMeters(double value)
    {
        return _scaleWorldCoordinates ? (value / Earth.Core.Ellipsoid.Wgs84.MaximumRadius) : value;
    }
}