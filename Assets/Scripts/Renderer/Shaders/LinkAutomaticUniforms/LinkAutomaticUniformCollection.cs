using System.Collections.ObjectModel;

namespace Earth.Renderer
{
    public class LinkAutomaticUniformCollection : KeyedCollection<string, LinkAutomaticUniform>
    {
        protected override string GetKeyForItem(LinkAutomaticUniform item)
        {
            return item.Name;
        }
    }
}