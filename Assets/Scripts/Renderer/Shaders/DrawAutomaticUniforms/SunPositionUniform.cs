using Earth.Core;

namespace Earth.Renderer
{
    internal class SunPositionUniform : DrawAutomaticUniform
    {
        public SunPositionUniform(Uniform uniform)
        {
            _uniform = (Uniform<Vector3F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.SunPosition.ToVector3F();
        }

        #endregion

        private Uniform<Vector3F> _uniform;
    }
}
