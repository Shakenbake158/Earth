using System;
using System.Drawing;

namespace Earth.Renderer
{
    public abstract class Mouse
    {
        public event EventHandler<MouseButtonEventArgs> ButtonDown;
        public event EventHandler<MouseButtonEventArgs> ButtonUp;
        public event EventHandler<MouseMoveEventArgs> Move;

        protected virtual void OnButtonDown(Point point, MouseButton button)
        {
            EventHandler<MouseButtonEventArgs> handler = ButtonDown;
            if (handler != null)
            {
                handler(this, new MouseButtonEventArgs(point, button, MouseButtonEvent.ButtonDown));
            }
        }

        protected virtual void OnButtonUp(Point point, MouseButton button)
        {
            EventHandler<MouseButtonEventArgs> handler = ButtonUp;
            if (handler != null)
            {
                handler(this, new MouseButtonEventArgs(point, button, MouseButtonEvent.ButtonUp));
            }
        }

        protected virtual void OnMove(Point point)
        {
            EventHandler<MouseMoveEventArgs> handler = Move;
            if (handler != null)
            {
                handler(this, new MouseMoveEventArgs(point));
            }
        }
    }
}