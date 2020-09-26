namespace Earth.Core
{
    public class VertexAttributeDoubleVector3 : VertexAttribute<Vector3D>
    {
        public VertexAttributeDoubleVector3(string name)
            : base(name, VertexAttributeType.EmulatedDoubleVector3)
        {
        }

        public VertexAttributeDoubleVector3(string name, int capacity)
            : base(name, VertexAttributeType.EmulatedDoubleVector3, capacity)
        {
        }
    }
}