using System;
using System.Collections.Generic;

namespace Earth.Core
{
    [CLSCompliant(false)]
    public class IndicesUnsignedInt : IndicesBase
    {
        public IndicesUnsignedInt()
            : base(IndicesType.UnsignedInt)
        {
            _values = new List<uint>();
        }

        public IndicesUnsignedInt(int capacity)
            : base(IndicesType.UnsignedInt)
        {
            _values = new List<uint>(capacity);
        }

        public List<uint> Values
        {
            get { return _values; }
        }

        public void AddTriangle(TriangleIndicesUnsignedInt triangle)
        {
            _values.Add(triangle.UI0);
            _values.Add(triangle.UI1);
            _values.Add(triangle.UI2);
        }

        private List<uint> _values;
    }
}