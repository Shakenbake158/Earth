﻿using System;
using System.Collections.Generic;

namespace Earth.Core
{
    [CLSCompliant(false)]
    public class IndicesUnsignedShort : IndicesBase
    {
        public IndicesUnsignedShort()
            : base(IndicesType.UnsignedShort)
        {
            _values = new List<ushort>();
        }

        public IndicesUnsignedShort(int capacity)
            : base(IndicesType.UnsignedShort)
        {
            _values = new List<ushort>(capacity);
        }

        public IList<ushort> Values
        {
            get { return _values; }
        }

        public void AddTriangle(TriangleIndicesUnsignedShort triangle)
        {
            _values.Add(triangle.UI0);
            _values.Add(triangle.UI1);
            _values.Add(triangle.UI2);
        }

        private List<ushort> _values;
    }
}