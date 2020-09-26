namespace Earth.Renderer
{
    internal class Wgs84HeightUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_wgs84Height"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new Wgs84HeightUniform(uniform);
        }

        #endregion
    }
}
