using Earth.Renderer;

namespace Earth.Scene
{
    public interface IRenderable
    {
        void Render(Context context, SceneState sceneState);
    }
}
