using System.Collections.ObjectModel;

namespace Earth.Renderer
{
    public class UniformCollection : KeyedCollection<string, Uniform>
    {
        protected override string GetKeyForItem(Uniform item)
        {
            return item.Name;
        }
    }
}
