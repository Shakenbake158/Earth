namespace Earth.Core
{
    public class VertexAttributeHalfFloatVector2 : VertexAttribute<Vector2H>
    {
        public VertexAttributeHalfFloatVector2(string name)
            : base(name, VertexAttributeType.HalfFloatVector2)
        {
        }

        public VertexAttributeHalfFloatVector2(string name, int capacity)
            : base(name, VertexAttributeType.HalfFloatVector2, capacity)
        {
        }
    }
}