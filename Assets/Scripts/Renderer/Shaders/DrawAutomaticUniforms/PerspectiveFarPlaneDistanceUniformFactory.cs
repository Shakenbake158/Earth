namespace Earth.Renderer
{
    internal class PerspectiveFarPlaneDistanceUniformFactory : DrawAutomaticUniformFactory
    {
        #region PerspectiveFarPlaneDistanceUniformFactory Members

        public override string Name
        {
            get { return "og_perspectiveFarPlaneDistance"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new PerspectiveFarPlaneDistanceUniform(uniform);
        }

        #endregion
    }
}
