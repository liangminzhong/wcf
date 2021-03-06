// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Runtime;
using System.ServiceModel;
using System.Xml;

namespace System.IdentityModel
{
    internal class XmlBuffer
    {
        private enum BufferState
        {
            Created,
            Writing,
            Reading,
        }

        private struct Section
        {
            private int _offset;
            private int _size;
            private XmlDictionaryReaderQuotas _quotas;

            public Section(int offset, int size, XmlDictionaryReaderQuotas quotas)
            {
                _offset = offset;
                _size = size;
                _quotas = quotas;
            }

            public int Offset
            {
                get { return _offset; }
            }

            public int Size
            {
                get { return _size; }
            }

            public XmlDictionaryReaderQuotas Quotas
            {
                get { return _quotas; }
            }
        }


        private Exception CreateInvalidStateException()
        {
            return new InvalidOperationException(SR.XmlBufferInInvalidState);
        }
    }
}
