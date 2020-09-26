namespace Earth.Renderer
{
    public abstract class DrawAutomaticUniformFactory
    {
        public abstract string Name { get; }
        public abstract DrawAutomaticUniform Create(Uniform uniform);
    }
}
