using System.Collections;

namespace Earth.Renderer
{
    public abstract class TextureUnits
    {
        public abstract TextureUnit this[int index] { get; }
        public abstract int Count { get; }
        public abstract IEnumerator GetEnumerator();
    }
}
