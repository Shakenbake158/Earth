using System;

namespace Earth.Renderer
{
    internal class PixelSizePerDistanceUniform : DrawAutomaticUniform
    {
        public PixelSizePerDistanceUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = (float)(Math.Tan(0.5 * sceneState.Camera.FieldOfViewY) * 2.0 / context.Viewport.Height);
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
