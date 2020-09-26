namespace Earth.Core
{
    public class VertexAttributeFloatVector3 : VertexAttribute<Vector3F>
    {
        public VertexAttributeFloatVector3(string name)
            : base(name, VertexAttributeType.FloatVector3)
        {
        }

        public VertexAttributeFloatVector3(string name, int capacity)
            : base(name, VertexAttributeType.FloatVector3, capacity)
        {
        }
    }
}