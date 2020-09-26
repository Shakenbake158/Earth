using Earth.Core;

namespace Earth.Renderer
{
    internal class ModelViewPerspectiveMatrixUniform : DrawAutomaticUniform
    {
        public ModelViewPerspectiveMatrixUniform(Uniform uniform)
        {
            _uniform = (Uniform<Matrix4F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.ModelViewPerspectiveMatrix.ToMatrix4F();
        }

        #endregion

        private Uniform<Matrix4F> _uniform;
    }
}
