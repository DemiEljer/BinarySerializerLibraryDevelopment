using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.TestModels
{
    [BinarySerializableObject]
    public class TestPackingModel
    {
        [BinaryTypeUInt(7)]
        public byte ByteField1 { get; set; } = 0x33;

        [BinaryTypeUInt(7, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public byte ByteField2 { get; set; } = 0x55;

        [BinaryTypeUInt(7, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public byte? ByteField3 { get; set; } = null;

        [BinaryTypeUInt(7, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public byte? ByteField4 { get; set; } = 0x77;

        [BinaryTypeUInt(7, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte?[] ByteFieldArray { get; set; } = new byte?[] { 0x11, 0x22, 0x33 };

        public static TestPackingModel Create()
        {
            return new TestPackingModel()
            {
                ByteField1 = RandomHandler.GetNextUInt8(7)
                , ByteField2 = RandomHandler.GetNextUInt8(7)
                , ByteField3 = RandomHandler.GetNextUInt8Nullable(7)
                , ByteField4 = RandomHandler.GetNextUInt8Nullable(7)
                , ByteFieldArray = new byte?[] { RandomHandler.GetNextUInt8Nullable(7), RandomHandler.GetNextUInt8Nullable(7), RandomHandler.GetNextUInt8Nullable(7) }
            };
        }
    }
}
