namespace Earth.Renderer
{
    public class PrimitiveRestart
    {
        public PrimitiveRestart()
        {
            Enabled = false;
            Index = 0;
        }

        public bool Enabled { get; set; }
        public int Index{ get; set; }
    }
}