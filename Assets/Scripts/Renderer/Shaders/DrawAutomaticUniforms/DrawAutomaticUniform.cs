using Earth.Scene;

namespace Earth.Renderer
{
    public abstract class DrawAutomaticUniform
    {
        public abstract void Set(Context context, DrawState drawState, SceneState sceneState);
    }
}
