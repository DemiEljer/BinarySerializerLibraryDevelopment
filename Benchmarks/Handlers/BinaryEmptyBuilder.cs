using BinarySerializerLibrary.Base;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Handlers
{
    public class BinaryEmptyBuilder : ABinaryDataWriter
    {
        private long _BitsCounter = 0;

        private byte[] _Data { get; } = new byte[8];

        public override long BytesCount => _BitsCounter / 8 + (_BitsCounter % 8 > 0 ? 1 : 0);

        public override void AppenBuilderAndShiftToEnd(ABinaryDataWriter builder)
        {
            
        }

        public override void AppendByteToHead(byte byteValue)
        {
            _BitsCounter += 8;
        }

        public override void AppendValue(int bitsCount, ulong value, BinaryAlignmentTypeEnum alignment)
        {
            _BitsCounter += bitsCount;
        }

        public override void Clear()
        {
            _BitsCounter = 0;
        }

        public override void MakeAlignment(BinaryAlignmentTypeEnum alignment)
        {
            
        }

        public override byte[] GetByteArray() => Array.Empty<byte>();
    }
}
