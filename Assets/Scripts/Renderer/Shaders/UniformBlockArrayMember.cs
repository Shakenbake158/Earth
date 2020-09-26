namespace Earth.Renderer
{
    public class UniformBlockArrayMember : UniformBlockMember
    {
        internal UniformBlockArrayMember(
            string name,
            UniformType type,
            int offsetInBytes,
            int length,
            int elementStrideInBytes)
            : base(name, type, offsetInBytes)
        {
            _length = length;
            _elementStrideInBytes = elementStrideInBytes;
        }

        public int Length
        {
            get { return _length; }
        }

        public int ElementStrideInBytes
        {
            get { return _elementStrideInBytes; }
        }

        private int _length;
        private int _elementStrideInBytes;
    }
}
