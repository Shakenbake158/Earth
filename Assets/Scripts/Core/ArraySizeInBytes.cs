﻿using System;

namespace Earth.Core
{
    public static class ArraySizeInBytes
    {
        public static int Size<T>(T[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }

            return values.Length * SizeInBytes<T>.Value;
        }
    }
}