namespace Earth.Renderer
{
    public class DrawState
    {
        public DrawState()
        {
            RenderState = new RenderState();
        }

        public DrawState(RenderState renderState, ShaderProgram shaderProgram, VertexArray vertexArray)
        {
            RenderState = renderState;
            ShaderProgram = shaderProgram;
            VertexArray = vertexArray;
        }

        public RenderState RenderState { get; set; }
        public ShaderProgram ShaderProgram { get; set; }
        public VertexArray VertexArray { get; set; }
    }
}
