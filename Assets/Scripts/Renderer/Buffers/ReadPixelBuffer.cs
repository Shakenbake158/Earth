using System.Drawing;
//using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Earth.Core;

namespace Earth.Renderer
{
    public abstract class ReadPixelBuffer : Disposable
    {
        public virtual void CopyFromSystemMemory<T>(T[] bufferInSystemMemory) where T : struct
        {
            CopyFromSystemMemory<T>(bufferInSystemMemory, 0);
        }

        public virtual void CopyFromSystemMemory<T>(T[] bufferInSystemMemory, int destinationOffsetInBytes) where T : struct
        {
            CopyFromSystemMemory<T>(bufferInSystemMemory, destinationOffsetInBytes, ArraySizeInBytes.Size(bufferInSystemMemory));
        }

        public abstract void CopyFromSystemMemory<T>(
            T[] bufferInSystemMemory,
            int destinationOffsetInBytes,
            int lengthInBytes) where T : struct;

        public abstract void CopyFromBitmap(Texture2D bitmap);

        public virtual T[] CopyToSystemMemory<T>() where T : struct
        {
            return CopyToSystemMemory<T>(0, SizeInBytes);
        }

        public abstract T[] CopyToSystemMemory<T>(int offsetInBytes, int sizeInBytes) where T : struct;
        public abstract Texture2D CopyToBitmap(int width, int height, TextureFormat pixelFormat);

        public abstract int SizeInBytes { get; }
        public abstract PixelBufferHint UsageHint { get; }
    }
}