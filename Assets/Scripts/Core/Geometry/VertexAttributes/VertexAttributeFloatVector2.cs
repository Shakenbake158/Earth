namespace Earth.Core
{
    public class VertexAttributeFloatVector2 : VertexAttribute<Vector2F>
    {
        public VertexAttributeFloatVector2(string name)
            : base(name, VertexAttributeType.FloatVector2)
        {
        }

        public VertexAttributeFloatVector2(string name, int capacity)
            : base(name, VertexAttributeType.FloatVector2, capacity)
        {
        }
    }
}