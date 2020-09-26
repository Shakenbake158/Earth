namespace Earth.Renderer
{
    public abstract class TextureUnit
    {
        public abstract Texture2D Texture { get; set; }
        public abstract TextureSampler TextureSampler { get; set; }
    }
}
