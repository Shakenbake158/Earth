namespace Earth.Renderer
{
    public class StencilTest
    {
        public StencilTest()
        {
            Enabled = false;
            FrontFace = new StencilTestFace();
            BackFace = new StencilTestFace();
        }

        public bool Enabled { get; set; }
        public StencilTestFace FrontFace { get; set; }
        public StencilTestFace BackFace { get; set; }
    }
}