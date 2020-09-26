using Earth.Core;

namespace Earth.Renderer
{
    internal class LightPropertiesUniform : DrawAutomaticUniform
    {
        public LightPropertiesUniform(Uniform uniform)
        {
            _uniform = (Uniform<Vector4F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = new Vector4F(
                sceneState.DiffuseIntensity,
                sceneState.SpecularIntensity,
                sceneState.AmbientIntensity,
                sceneState.Shininess);
        }

        #endregion

        private Uniform<Vector4F> _uniform;
    }
}
