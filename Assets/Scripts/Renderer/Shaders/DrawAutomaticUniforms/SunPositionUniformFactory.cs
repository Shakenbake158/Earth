namespace Earth.Renderer
{
    internal class SunPositionUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_sunPosition"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new SunPositionUniform(uniform);
        }

        #endregion
    }
}
