using System.Collections;
using UnityEngine;

namespace Earth.Renderer
{
    public abstract class ColorAttachments
    {
        public abstract Texture2D this[int index] { get; set; }
        public abstract int Count { get; }
        public abstract IEnumerator GetEnumerator();
    }
}