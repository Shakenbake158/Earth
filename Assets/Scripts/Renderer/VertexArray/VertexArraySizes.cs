using System;
using Earth.Core;

namespace Earth.Renderer
{
    internal static class VertexArraySizes
    {
        public static int SizeOf(IndexBufferDatatype type)
        {
            switch (type)
            {
                case IndexBufferDatatype.UnsignedShort:
                    return sizeof(ushort);
                case IndexBufferDatatype.UnsignedInt:
                    return sizeof(uint);
            }

            throw new ArgumentException("type");
        }

        public static int SizeOf(ComponentDatatype type)
        {
            switch (type)
            {
                case ComponentDatatype.Byte:
                case ComponentDatatype.UnsignedByte:
                    return sizeof(byte);
                case ComponentDatatype.Short:
                    return sizeof(short);
                case ComponentDatatype.UnsignedShort:
                    return sizeof(ushort);
                case ComponentDatatype.Int:
                    return sizeof(int);
                case ComponentDatatype.UnsignedInt:
                    return sizeof(uint);
                case ComponentDatatype.Float:
                    return sizeof(float);
                case ComponentDatatype.HalfFloat:
                    return SizeInBytes<Half>.Value;
            }

            throw new ArgumentException("type");
        }
    }
}