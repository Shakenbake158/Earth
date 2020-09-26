namespace Earth.Renderer
{
    internal class CameraLightPositionUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_cameraLightPosition"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new CameraLightPositionUniform(uniform);
        }

        #endregion
    }
}
