namespace Earth.Renderer
{
    internal class ModelViewOrthographicMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_modelViewOrthographicMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ModelViewOrthographicMatrixUniform(uniform);
        }

        #endregion
    }
}
