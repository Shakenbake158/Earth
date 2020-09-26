namespace Earth.Renderer
{
    public enum DepthTestFunction
    {
        Never,
        Less,
        Equal,
        LessThanOrEqual,
        Greater,
        NotEqual,
        GreaterThanOrEqual,
        Always
    }

    public class DepthTest
    {
        public DepthTest()
        {
            Enabled = true;
            Function = DepthTestFunction.Less;
        }

        public bool Enabled { get; set; }
        public DepthTestFunction Function { get; set; }
    }
}