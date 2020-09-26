namespace Earth.Core
{
    public class VertexAttributeHalfFloat : VertexAttribute<Half>
    {
        public VertexAttributeHalfFloat(string name)
            : base(name, VertexAttributeType.HalfFloat)
        {
        }

        public VertexAttributeHalfFloat(string name, int capacity)
            : base(name, VertexAttributeType.HalfFloat, capacity)
        {
        }
    }
}