using System;
using System.Collections.Generic;
using UnityEngine;

namespace Earth.Core
{
    public static class RectangleTessellator
    {
        public static UnityEngine.Mesh Compute(RectangleD rectangle, int numberOfPartitionsX, int numberOfPartitionsY)
        {
            if (numberOfPartitionsX < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPartitionsX");
            }

            if (numberOfPartitionsY < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPartitionsY");
            }

            UnityEngine.Mesh mesh = new UnityEngine.Mesh();
            //mesh. = PrimitiveType.Triangles;
            //mesh.FrontFaceWindingOrder = WindingOrder.Counterclockwise;

            int numberOfPositions = (numberOfPartitionsX + 1) * (numberOfPartitionsY + 1);
            //VertexAttributeFloatVector2 positionsAttribute = new VertexAttributeFloatVector2("position", numberOfPositions);
            List<UnityEngine.Vector3> positions = new List<Vector3>();
            //mesh.Attributes.Add(positionsAttribute);

            int numberOfIndices = (numberOfPartitionsX * numberOfPartitionsY) * 6;
            IndicesUnsignedInt indices = new IndicesUnsignedInt(numberOfIndices);
            //mesh.Indices = indices;

            //
            // Positions
            //
            Vector2D lowerLeft = rectangle.LowerLeft;
            Vector2D toUpperRight = rectangle.UpperRight - lowerLeft;

            for (int y = 0; y <= numberOfPartitionsY; ++y)
            {
                double deltaY = y / (double)numberOfPartitionsY;
                double currentY = lowerLeft.Y + (deltaY * toUpperRight.Y);

                for (int x = 0; x <= numberOfPartitionsX; ++x)
                {
                    double deltaX = x / (double)numberOfPartitionsX;
                    double currentX = lowerLeft.X + (deltaX * toUpperRight.X);
                    Vector2F tempVec = new Vector2D(currentX, currentY).ToVector2F();
                    positions.Add(new UnityEngine.Vector3(tempVec.X, tempVec.Y, 0.0f));
                }
            }
            mesh.vertices = positions.ToArray();

            //
            // Indices
            //
            int rowDelta = numberOfPartitionsX + 1;
            int i = 0;
            for (int y = 0; y < numberOfPartitionsY; ++y)
            {
                for (int x = 0; x < numberOfPartitionsX; ++x)
                {
                    indices.AddTriangle(new TriangleIndicesUnsignedInt(i, i + 1, rowDelta + (i + 1)));
                    indices.AddTriangle(new TriangleIndicesUnsignedInt(i, rowDelta + (i + 1), rowDelta + i));
                    i += 1;
                }
                i += 1;
            }

            List<int> index = new List<int>();
            for (int id = 0; id < indices.Values.Count; id++)
            {
                index.Add((int)(indices.Values[id]));
            }
            mesh.SetIndices(index.ToArray(), MeshTopology.Triangles, 0);

            return mesh;
        }
    }
}