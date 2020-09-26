﻿using Earth.Core;

namespace Earth.Renderer
{
    internal class ModelViewPerspectiveMatrixRelativeToEyeUniform : DrawAutomaticUniform
    {
        public ModelViewPerspectiveMatrixRelativeToEyeUniform(Uniform uniform)
        {
            _uniform = (Uniform<Matrix4F>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = sceneState.ModelViewPerspectiveMatrixRelativeToEye.ToMatrix4F();
        }

        #endregion

        private Uniform<Matrix4F> _uniform;
    }
}
