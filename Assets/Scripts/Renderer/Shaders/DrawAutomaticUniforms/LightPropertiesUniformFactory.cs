namespace Earth.Renderer
{
    internal class LightPropertiesUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_diffuseSpecularAmbientShininess"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new LightPropertiesUniform(uniform);
        }

        #endregion
    }
}
