using Earth.Core;

namespace Earth.Renderer
{
    internal class CameraEyeUniform : DrawAutomaticUniform
    {
        public CameraEyeUniform(Uniform uniform)
        {
            _uniform = (Uniform<Vector3F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.Camera.Eye.ToVector3F();
        }

        #endregion

        private Uniform<Vector3F> _uniform;
    }
}
