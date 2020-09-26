using System.Collections;

namespace Earth.Renderer
{
    public abstract class VertexBufferAttributes
    {
        public abstract VertexBufferAttribute this[int index] { get; set; }
        public abstract int Count { get; }
        public abstract int MaximumCount { get; }
        public abstract IEnumerator GetEnumerator();
    }
}
