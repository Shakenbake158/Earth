﻿using System.Drawing;

namespace Earth.Renderer
{
    public class ScissorTest
    {
        public ScissorTest()
        {
            Enabled = false;
            Rectangle = new Rectangle(0, 0, 0, 0);
        }

        public bool Enabled { get; set; }
        public Rectangle Rectangle { get; set; }
    }
}