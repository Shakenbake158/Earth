namespace Earth.Renderer
{
    internal class PixelSizePerDistanceUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_pixelSizePerDistance"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new PixelSizePerDistanceUniform(uniform);
        }

        #endregion
    }
}
