namespace Earth.Renderer
{
    /// <summary>
    /// Does not own vertex and index buffers.  They must be disposed.
    /// </summary>
    public class MeshBuffers
    {
        public virtual VertexBufferAttributes Attributes
        {
            get { return _attributes; }
        }

        public IndexBuffer IndexBuffer { get; set; }

        private MeshVertexBufferAttributes _attributes = new MeshVertexBufferAttributes();
    }
}