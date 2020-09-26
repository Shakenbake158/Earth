namespace Earth.Renderer
{
    internal class CameraEyeLowUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_cameraEyeLow"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new CameraEyeLowUniform(uniform);
        }

        #endregion
    }
}
