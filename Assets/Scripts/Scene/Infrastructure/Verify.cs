using System;
using Earth.Core;
using Earth.Renderer;

namespace Earth.Scene
{
    internal static class Verify
    {
        public static void ThrowInvalidOperationIfNull(Texture2D texture, string memberName)
        {
            if (texture == null)
            {
                throw new InvalidOperationException(memberName);
            }
        }

        public static void ThrowIfNull(Context context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
        }

        public static void ThrowIfNull(SceneState sceneState)
        {
            if (sceneState == null)
            {
                throw new ArgumentNullException("sceneState");
            }
        }

        public static void ThrowIfNull(Ellipsoid globeShape)
        {
            if (globeShape == null)
            {
                throw new ArgumentNullException("globeShape");
            }
        }

        public static void ThrowIfNull(Shapefile shapefile)
        {
            if (shapefile == null)
            {
                throw new ArgumentNullException("shapefile");
            }
        }

        public static void ThrowIfNull(ShapefileAppearance appearance)
        {
            if (appearance == null)
            {
                throw new ArgumentNullException("appearance");
            }
        }
    }
}