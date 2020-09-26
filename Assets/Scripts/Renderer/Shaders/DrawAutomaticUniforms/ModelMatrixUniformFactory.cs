namespace Earth.Renderer
{
    internal class ModelMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_modelMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ModelMatrixUniform(uniform);
        }

        #endregion
    }
}
