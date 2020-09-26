using System;

namespace Earth.Core
{
    internal static class SubdivisionUtility
    {
        public static int NumberOfTriangles(int numberOfSubdivisions)
        {
            int numberOfTriangles = 0;
            for (int i = 0; i <= numberOfSubdivisions; ++i)
            {
                numberOfTriangles += Convert.ToInt32(Math.Pow(4, i));
            }
            numberOfTriangles *= 4;

            return numberOfTriangles;
        }

        public static int NumberOfVertices(int numberOfSubdivisions)
        {
            int numberOfVertices = 0;
            for (int i = 0; i < numberOfSubdivisions; ++i)
            {
                numberOfVertices += Convert.ToInt32(Math.Pow(4, i));
            }
            numberOfVertices = 4 + (12 * numberOfVertices);

            return numberOfVertices;
        }

        public static Vector2H ComputeTextureCoordinate(Vector3D position)
        {
            return new Vector2H((Math.Atan2(position.Y, position.X) / Trig.TwoPi) + 0.5,
                (Math.Asin(position.Z) / Math.PI) + 0.5);
        }
    }
}