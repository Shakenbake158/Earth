namespace Earth.Renderer
{
    internal class TextureUniform : LinkAutomaticUniform
    {
        public TextureUniform(int textureUnit)
        {
            _textureUnit = textureUnit;
        }

        #region LinkAutomaticUniform Members

        public override string Name 
        { 
            get { return "og_texture" + _textureUnit; }
        }

        public override void Set(Uniform uniform)
        {
            ((Uniform<int>)uniform).Value = _textureUnit;
        }

        #endregion

        int _textureUnit;
    }
}