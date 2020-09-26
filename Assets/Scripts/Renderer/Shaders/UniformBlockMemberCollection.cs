using System.Collections.ObjectModel;

namespace Earth.Renderer
{
    public class UniformBlockMemberCollection : KeyedCollection<string, UniformBlockMember>
    {
        protected override string GetKeyForItem(UniformBlockMember item)
        {
            return item.Name;
        }
    }
}
