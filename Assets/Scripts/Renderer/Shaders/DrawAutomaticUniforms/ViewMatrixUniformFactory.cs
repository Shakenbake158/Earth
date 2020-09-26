namespace Earth.Renderer
{
    internal class ViewMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_viewMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ViewMatrixUniform(uniform);
        }

        #endregion
    }
}
