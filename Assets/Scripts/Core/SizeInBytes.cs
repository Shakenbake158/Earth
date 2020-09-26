using System.Runtime.InteropServices;

namespace Earth.Core
{
    public static class SizeInBytes<T>
    {
        public static readonly int Value = Marshal.SizeOf(typeof(T));
    }
}