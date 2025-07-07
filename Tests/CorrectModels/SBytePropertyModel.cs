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
    public class SBytePropertyModel : BasePropertyModel<sbyte>, IBasePropertyModel<sbyte>
    {
        #region Atomic

        [BinaryTypeInt(8)]
        public sbyte Value { get => _Value; set => _Value = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public sbyte? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public sbyte? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public sbyte ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public sbyte? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public sbyte? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public sbyte?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte>? List { get => _List; set => _List = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeInt(8, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<sbyte?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override sbyte? _GetRandomNullableValue() => RandomHandler.GetNextInt8Nullable();

        protected override sbyte _GetRandomValue() => RandomHandler.GetNextInt8();
    }
}
