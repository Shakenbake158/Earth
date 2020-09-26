namespace Earth.Renderer
{
    internal class ModelViewPerspectiveMatrixRelativeToEyeUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_modelViewPerspectiveMatrixRelativeToEye"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ModelViewPerspectiveMatrixRelativeToEyeUniform(uniform);
        }

        #endregion
    }
}
