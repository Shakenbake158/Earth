using System.Collections.ObjectModel;

namespace Earth.Renderer
{
    public class UniformBlockCollection : KeyedCollection<string, UniformBlock>
    {
        protected override string GetKeyForItem(UniformBlock item)
        {
            return item.Name;
        }
    }
}
