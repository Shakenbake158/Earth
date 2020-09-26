namespace Earth.Renderer
{
    internal class WindowToWorldNearPlaneUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_windowToWorldNearPlane"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new WindowToWorldNearPlaneUniform(uniform);
        }

        #endregion
    }
}
