using Earth.Core;

namespace Earth.Renderer
{
    internal class Wgs84HeightUniform : DrawAutomaticUniform
    {
        public Wgs84HeightUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = (float)sceneState.Camera.Height(Ellipsoid.Wgs84);
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
