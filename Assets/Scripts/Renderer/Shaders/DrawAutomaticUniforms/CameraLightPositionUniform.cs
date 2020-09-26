using Earth.Core;

namespace Earth.Renderer
{
    internal class CameraLightPositionUniform : DrawAutomaticUniform
    {
        public CameraLightPositionUniform(Uniform uniform)
        {
            _uniform = (Uniform<Vector3F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.CameraLightPosition.ToVector3F();
        }

        #endregion

        private Uniform<Vector3F> _uniform;
    }
}
