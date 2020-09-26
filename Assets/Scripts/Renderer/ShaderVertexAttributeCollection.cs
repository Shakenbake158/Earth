using System.Collections.ObjectModel;

namespace Earth.Renderer
{
    public class ShaderVertexAttributeCollection : KeyedCollection<string, ShaderVertexAttribute>
    {
        protected override string GetKeyForItem(ShaderVertexAttribute item)
        {
            return item.Name;
        }
    }
}