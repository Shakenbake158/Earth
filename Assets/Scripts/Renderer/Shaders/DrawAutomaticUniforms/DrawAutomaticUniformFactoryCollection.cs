using System.Collections.ObjectModel;

namespace Earth.Renderer
{
    public class DrawAutomaticUniformFactoryCollection : KeyedCollection<string, DrawAutomaticUniformFactory>
    {
        protected override string GetKeyForItem(DrawAutomaticUniformFactory item)
        {
            return item.Name;
        }
    }
}
