﻿using System;
using Earth.Core;
using Earth.Renderer;

namespace Earth.Scene
{
    internal class ClipmapLevel : IDisposable
    {
        public RasterLevel Terrain;
        public RasterLevel Imagery;

        public Texture2D HeightTexture;
        public Texture2D NormalTexture;
        public Texture2D ImageryTexture;

        public Vector2I OriginInTextures = new Vector2I(0, 0);
        public Vector2I OriginInImagery = new Vector2I(0, 0);

        public bool OffsetStripOnNorth;
        public bool OffsetStripOnEast;

        public class Extent
        {
            public Extent()
            {
            }

            public Extent(int west, int south, int east, int north)
            {
                West = west;
                South = south;
                East = east;
                North = north;
            }

            public int West;
            public int South;
            public int East;
            public int North;
        }

        public Extent CurrentExtent = new Extent(1, 1, 0, 0);
        public Extent NextExtent = new Extent();

        public Extent CurrentImageryExtent = new Extent(1, 1, 0, 0);
        public Extent NextImageryExtent = new Extent();

        public ClipmapLevel FinerLevel;
        public ClipmapLevel CoarserLevel;

        public int ImageryWidth;
        public int ImageryHeight;

        public void Dispose()
        {
            HeightTexture.Dispose();
            NormalTexture.Dispose();
            ImageryTexture.Dispose();
        }
    }
}
