using System.IO;

namespace Earth.Renderer
{
    public static class PersistentView
    {
        public static void Execute(string filename, GraphicsWindow window, Camera camera)
        {
            if (File.Exists(filename))
            {
                camera.LoadView(filename);
            }

            window.Keyboard.KeyDown += delegate(object sender, KeyboardKeyEventArgs e)
            {
                if (e.Key == KeyboardKey.Space)
                {
                    camera.SaveView(filename);
                }
            };
        }
    }
}