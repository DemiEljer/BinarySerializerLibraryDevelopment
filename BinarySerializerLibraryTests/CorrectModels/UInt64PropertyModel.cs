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
    public class UInt64PropertyModel : BasePropertyModel<UInt64>, IBasePropertyModel<UInt64>
    {
        #region Atomic

        [BinaryTypeUInt(64)]
        public UInt64 Value { get => _Value; set => _Value = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public UInt64? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public UInt64? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt64 ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt64? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public UInt64? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public UInt64?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64>? List { get => _List; set => _List = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeUInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<UInt64?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override UInt64? _GetRandomNullableValue() => RandomHandler.GetNextUInt64Nullable();

        protected override UInt64 _GetRandomValue() => RandomHandler.GetNextUInt64();
    }
}
