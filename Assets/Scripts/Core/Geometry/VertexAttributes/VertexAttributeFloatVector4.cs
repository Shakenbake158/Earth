namespace Earth.Core
{
    public class VertexAttributeFloatVector4 : VertexAttribute<Vector4F>
    {
        public VertexAttributeFloatVector4(string name)
            : base(name, VertexAttributeType.FloatVector4)
        {
        }

        public VertexAttributeFloatVector4(string name, int capacity)
            : base(name, VertexAttributeType.FloatVector4, capacity)
        {
        }
    }
}