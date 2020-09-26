using Earth.Core;

namespace Earth.Renderer
{
    internal class CameraEyeHighUniform : DrawAutomaticUniform
    {
        public CameraEyeHighUniform(Uniform uniform)
        {
            _uniform = (Uniform<Vector3F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.Camera.EyeHigh;
        }

        #endregion

        private Uniform<Vector3F> _uniform;
    }
}
