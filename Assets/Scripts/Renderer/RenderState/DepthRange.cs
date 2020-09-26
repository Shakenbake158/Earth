namespace Earth.Renderer
{
    public class DepthRange
    {
        public DepthRange()
        {
            Near = 0.0;
            Far = 1.0;
        }

        public double Near { get; set; }
        public double Far { get; set; }
    }
}