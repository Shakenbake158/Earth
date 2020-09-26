namespace Earth.Renderer
{
    internal class HighResolutionSnapScaleUniformFactory : DrawAutomaticUniformFactory
    {
        #region HighResolutionSnapScaleUniformFactory Members

        public override string Name
        {
            get { return "og_highResolutionSnapScale"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new HighResolutionSnapScaleUniform(uniform);
        }

        #endregion
    }
}
