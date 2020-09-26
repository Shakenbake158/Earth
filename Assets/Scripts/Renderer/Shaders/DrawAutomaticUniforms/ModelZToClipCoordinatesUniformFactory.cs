namespace Earth.Renderer
{
    internal class ModelZToClipCoordinatesUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_modelZToClipCoordinates"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new ModelZToClipCoordinatesUniform(uniform);
        }

        #endregion
    }
}
