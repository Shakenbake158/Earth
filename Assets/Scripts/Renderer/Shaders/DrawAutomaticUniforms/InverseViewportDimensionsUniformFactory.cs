namespace Earth.Renderer
{
    internal class InverseViewportDimensionsUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_inverseViewportDimensions"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new InverseViewportDimensionsUniform(uniform);
        }

        #endregion
    }
}
