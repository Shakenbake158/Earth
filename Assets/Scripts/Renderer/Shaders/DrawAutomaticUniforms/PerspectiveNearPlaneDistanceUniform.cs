namespace Earth.Renderer
{
    internal class PerspectiveNearPlaneDistanceUniform : DrawAutomaticUniform
    {
        public PerspectiveNearPlaneDistanceUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = (float)sceneState.Camera.PerspectiveNearPlaneDistance;
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
