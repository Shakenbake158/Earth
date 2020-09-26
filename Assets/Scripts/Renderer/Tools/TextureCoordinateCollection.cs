using System.Collections.Generic;
using System.Collections.ObjectModel;
using Earth.Core;

namespace Earth.Renderer
{
    public class TextureCoordinateCollection : Collection<RectangleH>
    {
        public TextureCoordinateCollection(IList<RectangleH> list)
            : base(list)
        {
        }
    }
}