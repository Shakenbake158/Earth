using System;
using System.Drawing;

namespace Earth.Renderer
{
    public class MouseMoveEventArgs : EventArgs
    {
        public MouseMoveEventArgs(Point point)
        {
            _point = point;
        }

        public Point Point
        {
            get { return _point; }
        }

        private Point _point;
    }
}