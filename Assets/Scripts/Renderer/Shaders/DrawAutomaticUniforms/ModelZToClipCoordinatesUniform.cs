using Earth.Core;

namespace Earth.Renderer
{
    internal class ModelZToClipCoordinatesUniform : DrawAutomaticUniform
    {
        public ModelZToClipCoordinatesUniform(Uniform uniform)
        {
            _uniform = (Uniform<Matrix42<float>>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = Matrix42<float>.DoubleToFloat(sceneState.ModelZToClipCoordinates);
        }

        #endregion

        private Uniform<Matrix42<float>> _uniform;
    }
}
