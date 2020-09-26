namespace Earth.Renderer
{
    internal class PerspectiveMatrixUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_perspectiveMatrix"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new PerspectiveMatrixUniform(uniform);
        }

        #endregion
    }
}
