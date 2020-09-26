using Earth.Core;

namespace Earth.Renderer
{
    internal class ViewportTransformationMatrixUniform : DrawAutomaticUniform
    {
        public ViewportTransformationMatrixUniform(Uniform uniform)
        {
            _uniform = (Uniform<Matrix4F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.ComputeViewportTransformationMatrix(context.Viewport,
                drawState.RenderState.DepthRange.Near, drawState.RenderState.DepthRange.Far).ToMatrix4F();
        }

        #endregion

        private Uniform<Matrix4F> _uniform;
    }
}
