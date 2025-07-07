using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Models
{
    [BinarySerializableObject]
    public class BytePropertyModel : BasePropertyModel<byte>, IBasePropertyModel<byte>
    {
        #region Atomic

        [BinaryTypeUInt(8)]
        public byte Value { get => _Value; set => _Value = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public byte? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public byte? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public byte ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public byte? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public byte? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public byte?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte>? List { get => _List; set => _List = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeUInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<byte?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override byte? _GetRandomNullableValue() => RandomHandler.GetNextUInt8Nullable();

        protected override byte _GetRandomValue() => RandomHandler.GetNextUInt8();
    }
}
