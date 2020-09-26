using System;
using Earth.Renderer;

namespace Earth.Scene
{
    internal abstract class ShapefileGraphics : IRenderable, IDisposable
    {
        public abstract void Render(Context context, SceneState sceneState);
        public abstract void Dispose();

        public abstract bool Wireframe { get; set; }
    }
}