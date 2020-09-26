using System.Drawing;
using Earth.Core;

namespace Earth.Renderer
{
    internal class ViewportUniform : DrawAutomaticUniform
    {
        public ViewportUniform(Uniform uniform)
        {
            _uniform = (Uniform<Vector4F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            //
            // viewport.Bottom should really be used but Rectangle goes top to botom, not bottom to top.
            //
            Rectangle viewport = context.Viewport;
            _uniform.Value = new Vector4F(viewport.Left, viewport.Top, viewport.Width, viewport.Height);
        }

        #endregion

        private Uniform<Vector4F> _uniform;
    }
}
