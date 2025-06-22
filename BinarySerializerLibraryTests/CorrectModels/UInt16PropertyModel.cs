using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Models
{
    [BinarySerializableObject]
    public class UInt16PropertyModel : BasePropertyModel<UInt16>, IBasePropertyModel<UInt16>
    {
        #region Atomic

        [BinaryTypeUInt(16)]
        public UInt16 Value { get => _Value; set => _Value = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public UInt16? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public UInt16? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt16 ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt16? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt16? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt16?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16>? List { get => _List; set => _List = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeUInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt16?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override UInt16? _GetRandomNullableValue() => RandomHandler.GetNextUInt16Nullable();

        protected override UInt16 _GetRandomValue() => RandomHandler.GetNextUInt16();
    }
}
