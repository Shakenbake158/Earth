using System.Collections.Generic;
using System.Collections.ObjectModel;
using Earth.Core;

namespace Earth.Scene
{
    public class GridResolutionCollection : Collection<GridResolution>
    {
        public GridResolutionCollection(IList<GridResolution> list)
            : base(list)
        {
        }
    }
}