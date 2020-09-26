using System;
using System.Drawing;

namespace Earth.Core
{
    public class VertexAttributeRGB : VertexAttribute<byte>
    {
        public VertexAttributeRGB(string name)
            : base(name, VertexAttributeType.UnsignedByte)
        {
        }

        public VertexAttributeRGB(string name, int capacity)
            : base(name, VertexAttributeType.UnsignedByte, capacity * 3)
        {
            if (capacity > int.MaxValue / 3)
            {
                throw new ArgumentOutOfRangeException("capacity", "capacity causes int overflow.");
            }
        }

        public void AddColor(Color color)
        {
            Values.Add(color.R);
            Values.Add(color.G);
            Values.Add(color.B);
        }
    }
}