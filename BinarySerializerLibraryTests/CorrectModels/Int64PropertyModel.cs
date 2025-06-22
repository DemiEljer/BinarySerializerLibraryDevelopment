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
    public class Int64PropertyModel : BasePropertyModel<Int64>, IBasePropertyModel<Int64>
    {
        #region Atomic

        [BinaryTypeInt(64)]
        public Int64 Value { get => _Value; set => _Value = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public Int64? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public Int64? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int64 ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int64? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int64? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int64?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64>? List { get => _List; set => _List = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeInt(64, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int64?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override Int64? _GetRandomNullableValue() => RandomHandler.GetNextInt64Nullable();

        protected override Int64 _GetRandomValue() => RandomHandler.GetNextInt64();
    }
}
