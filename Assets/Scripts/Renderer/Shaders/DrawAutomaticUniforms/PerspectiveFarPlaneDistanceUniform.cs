namespace Earth.Renderer
{
    internal class PerspectiveFarPlaneDistanceUniform : DrawAutomaticUniform
    {
        public PerspectiveFarPlaneDistanceUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = (float)sceneState.Camera.PerspectiveFarPlaneDistance;
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
