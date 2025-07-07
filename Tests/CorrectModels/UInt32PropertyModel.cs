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
    public class UInt32PropertyModel : BasePropertyModel<UInt32>, IBasePropertyModel<UInt32>
    {
        #region Atomic

        [BinaryTypeUInt(32)]
        public UInt32 Value { get => _Value; set => _Value = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public UInt32? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public UInt32? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt32 ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt32? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt32? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt32?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32>? List { get => _List; set => _List = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeUInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt32?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override UInt32? _GetRandomNullableValue() => RandomHandler.GetNextUInt32Nullable();

        protected override UInt32 _GetRandomValue() => RandomHandler.GetNextUInt32();
    }
}
