namespace Earth.Renderer
{
    internal class PerspectiveNearPlaneDistanceUniformFactory : DrawAutomaticUniformFactory
    {
        #region PerspectiveNearPlaneDistanceUniformFactory Members

        public override string Name
        {
            get { return "og_perspectiveNearPlaneDistance"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new PerspectiveNearPlaneDistanceUniform(uniform);
        }

        #endregion
    }
}
