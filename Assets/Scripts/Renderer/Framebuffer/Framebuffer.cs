using UnityEngine;
using Earth.Core;

namespace Earth.Renderer
{
    public abstract class Framebuffer : Disposable
    {
        public abstract ColorAttachments ColorAttachments { get; }
        public abstract Texture2D DepthAttachment { get; set; }
        public abstract Texture2D DepthStencilAttachment { get; set; }
    }
}