namespace Earth.Core
{
    public enum PrimitiveType
    {
        Points,
        Lines,
        LineLoop,
        LineStrip,
        Triangles,
        TriangleStrip,
        TriangleFan,
        LinesAdjacency,
        LineStripAdjacency,
        TrianglesAdjacency,
        TriangleStripAdjacency
    }

    public enum WindingOrder
    {
        Clockwise,
        Counterclockwise
    }

    public class Mesh
    {
        public Mesh()
        {
            _attributes = new VertexAttributeCollection();
        }

        public VertexAttributeCollection Attributes
        {
            get { return _attributes; }
        }

        public IndicesBase Indices { get; set; }

        public PrimitiveType PrimitiveType { get; set; }
        public WindingOrder FrontFaceWindingOrder { get; set; }

        private VertexAttributeCollection _attributes;
    }
}