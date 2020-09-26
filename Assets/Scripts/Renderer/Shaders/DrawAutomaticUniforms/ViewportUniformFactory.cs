namespace Earth.Renderer
{
    internal class ViewportUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_viewport"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ViewportUniform(uniform);
        }

        #endregion
    }
}
