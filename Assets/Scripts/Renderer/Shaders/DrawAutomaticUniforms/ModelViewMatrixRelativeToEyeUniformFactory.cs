namespace Earth.Renderer
{
    internal class ModelViewMatrixRelativeToEyeUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_modelViewMatrixRelativeToEye"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ModelViewMatrixRelativeToEyeUniform(uniform);
        }

        #endregion
    }
}
