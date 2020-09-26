using Earth.Core;

namespace Earth.Renderer
{
    public abstract class VertexArray : Disposable
    {
        public virtual VertexBufferAttributes Attributes
        {
            get { return null; }
        }

        public virtual IndexBuffer IndexBuffer
        {
            get { return null; }
            set { }
        }

        public bool DisposeBuffers { get; set; }
    }
}
