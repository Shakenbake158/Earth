namespace Earth.Core
{
    public abstract class IndicesBase
    {
        protected IndicesBase(IndicesType type)
        {
            _type = type;
        }

        public IndicesType Datatype
        {
            get { return _type; }
        }

        private IndicesType _type;
    }
}