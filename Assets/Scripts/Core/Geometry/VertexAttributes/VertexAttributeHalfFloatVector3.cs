namespace Earth.Core
{
    public class VertexAttributeHalfFloatVector3 : VertexAttribute<Vector3H>
    {
        public VertexAttributeHalfFloatVector3(string name)
            : base(name, VertexAttributeType.HalfFloatVector3)
        {
        }

        public VertexAttributeHalfFloatVector3(string name, int capacity)
            : base(name, VertexAttributeType.HalfFloatVector3, capacity)
        {
        }
    }
}