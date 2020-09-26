using System.IO;
using System.Reflection;

namespace Earth.Scene
{
    internal static class EmbeddedResources
    {
        public static string GetText(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            //foreach (string name in assembly.GetManifestResourceNames())
            //{
            //    System.Console.WriteLine(name);
            //}
            
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            StreamReader streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        }
    }
}
