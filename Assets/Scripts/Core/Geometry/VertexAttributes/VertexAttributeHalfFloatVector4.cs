namespace Earth.Core
{
    public class VertexAttributeHalfFloatVector4 : VertexAttribute<Vector4H>
    {
        public VertexAttributeHalfFloatVector4(string name)
            : base(name, VertexAttributeType.HalfFloatVector4)
        {
        }

        public VertexAttributeHalfFloatVector4(string name, int capacity)
            : base(name, VertexAttributeType.HalfFloatVector4, capacity)
        {
        }
    }
}