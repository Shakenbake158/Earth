﻿using System;
using System.Collections;
using System.Diagnostics;

namespace Earth.Renderer
{
    internal class MeshVertexBufferAttributes : VertexBufferAttributes
    {
        public MeshVertexBufferAttributes()
        {
            _attributes = new VertexBufferAttribute[Device.MaximumNumberOfVertexAttributes];
        }

        #region vertexBufferAttributes Members

        public override VertexBufferAttribute this[int index]
        {
            get { return _attributes[index]; }

            set
            {
                if ((_attributes[index] != null) && (value == null))
                {
                    --_count;
                }
                else if ((_attributes[index] == null) && (value != null))
                {
                    ++_count;
                }

                _attributes[index] = value;
            }
        }

        public override int Count
        {
            get { return _count; }
        }

        public override int MaximumCount
        {
            get { return _attributes.Length; }
        }

        public override IEnumerator GetEnumerator()
        {
#pragma warning disable 219
            foreach (VertexBufferAttribute vb in _attributes)
            {
                if (_attributes != null)
                {
                    yield return _attributes;
                }
            }
#pragma warning restore 219
        }

        #endregion

        private VertexBufferAttribute[] _attributes;
        private int _count;
    }
}