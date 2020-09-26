namespace Earth.Renderer
{
    internal class CameraEyeHighUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_cameraEyeHigh"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new CameraEyeHighUniform(uniform);
        }

        #endregion
    }
}
