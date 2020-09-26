using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Earth.Scene
{
    public class RasterLevelCollection : ReadOnlyCollection<RasterLevel>
    {
        public RasterLevelCollection(IList<RasterLevel> collectionToWrap) :
            base(collectionToWrap)
        {
        }
    }
}
