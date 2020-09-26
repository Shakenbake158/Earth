namespace Earth.Core
{
    public class VertexAttributeFloat : VertexAttribute<float>
    {
        public VertexAttributeFloat(string name)
            : base(name, VertexAttributeType.Float)
        {
        }

        public VertexAttributeFloat(string name, int capacity)
            : base(name, VertexAttributeType.Float, capacity)
        {
        }
    }
}