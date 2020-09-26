namespace Earth.Renderer
{
    public class UniformBlockMember
    {
        internal UniformBlockMember(
            string name,
            UniformType type,
            int offsetInBytes)
        {
            _name = name;
            _type = type;
            _offsetInBytes = offsetInBytes;
        }

        public string Name
        {
            get { return _name; }
        }

        public UniformType Datatype
        {
            get { return _type; }
        }

        public int OffsetInBytes
        {
            get { return _offsetInBytes; }
        }

        private string _name;
        private UniformType _type;
        private int _offsetInBytes;
    }
}
