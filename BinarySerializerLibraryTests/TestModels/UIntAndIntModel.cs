using BinarySerializerLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.TestModels
{
    [BinarySerializableObjectAttribute]
    public class UIntAndIntModel
    {
        [BinaryTypeUInt(7)]
        public byte UIntField7 { get; set; } = 0;

        [BinaryTypeUInt(15)]
        public UInt16 UIntField15 { get; set; } = 0;

        [BinaryTypeUInt(31)]
        public UInt32 UIntField31 { get; set; } = 0;

        [BinaryTypeUInt(63)]
        public UInt64 UIntField63 { get; set; } = 0;

        [BinaryTypeUInt(0)]
        public UInt64 UIntField0 { get; set; } = 0;

        [BinaryTypeInt(7)]
        public sbyte IntField7 { get; set; } = 0;

        [BinaryTypeInt(15)]
        public Int16 IntField15 { get; set; } = 0;

        [BinaryTypeInt(31)]
        public Int32 IntField31 { get; set; } = 0;

        [BinaryTypeInt(63)]
        public Int64 IntField63 { get; set; } = 0;

        [BinaryTypeInt(0)]
        public Int64 IntField0 { get; set; } = 0;
    }
}
