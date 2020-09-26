namespace Earth.Core
{
    public class VertexAttributeByte : VertexAttribute<byte>
    {
        public VertexAttributeByte(string name)
            : base(name, VertexAttributeType.UnsignedByte)
        {
        }

        public VertexAttributeByte(string name, int capacity)
            : base(name, VertexAttributeType.UnsignedByte, capacity)
        {
        }
    }
}