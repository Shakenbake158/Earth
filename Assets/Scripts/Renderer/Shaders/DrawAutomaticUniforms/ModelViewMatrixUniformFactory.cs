namespace Earth.Renderer
{
    internal class ModelViewMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_modelViewMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ModelViewMatrixUniform(uniform);
        }

        #endregion
    }
}
