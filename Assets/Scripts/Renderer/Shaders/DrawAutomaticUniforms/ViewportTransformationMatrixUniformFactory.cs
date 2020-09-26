namespace Earth.Renderer
{
    internal class ViewportTransformationMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_viewportTransformationMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ViewportTransformationMatrixUniform(uniform);
        }

        #endregion
    }
}
