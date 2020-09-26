using System;

namespace Earth.Renderer
{
    public class KeyboardKeyEventArgs : EventArgs
    {
        public KeyboardKeyEventArgs(KeyboardKeyEvent keyboardEvent, KeyboardKey key)
        {
            _keyboardEvent = keyboardEvent;
            _key = key;
        }

        public KeyboardKeyEvent KeyboardEvent
        {
            get { return _keyboardEvent; }
        }

        public KeyboardKey Key
        {
            get { return _key; }
        }

        private KeyboardKeyEvent _keyboardEvent;
        private KeyboardKey _key;
    }
}