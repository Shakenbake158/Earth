namespace Earth.Renderer
{
    internal class HighResolutionSnapScaleUniform : DrawAutomaticUniform
    {
        public HighResolutionSnapScaleUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = (float)sceneState.HighResolutionSnapScale;
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
