namespace Earth.Renderer
{
    internal class ViewportOrthographicMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_viewportOrthographicMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ViewportOrthographicMatrixUniform(uniform);
        }

        #endregion
    }
}
