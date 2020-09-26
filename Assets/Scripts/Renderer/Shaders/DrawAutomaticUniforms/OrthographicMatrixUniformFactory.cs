namespace Earth.Renderer
{
    internal class OrthographicMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_orthographicMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new OrthographicMatrixUniform(uniform);
        }

        #endregion
    }
}
