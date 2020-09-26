namespace Earth.Core
{
    public class PointShape : Shape
    {
        internal PointShape(int recordNumber, Vector2D position)
            : base(recordNumber, ShapeType.Point)
        {
            _position = position;
        }

        public Vector2D Position
        {
            get { return _position; }
        }

        private readonly Vector2D _position;
    }
}