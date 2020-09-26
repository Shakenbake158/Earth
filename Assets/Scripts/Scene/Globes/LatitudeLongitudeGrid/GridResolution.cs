using Earth.Core;

namespace Earth.Scene
{
    public class GridResolution
    {
        public GridResolution(Interval interval, Vector2D resolution)
        {
            _interval = interval;
            _resolution = resolution;
        }

        public Interval Interval { get { return _interval; } }
        public Vector2D Resolution { get { return _resolution; } }

        private readonly Interval _interval;
        private readonly Vector2D _resolution;
    }
}