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
    public class Int32PropertyModel : BasePropertyModel<Int32>, IBasePropertyModel<Int32>
    {
        #region Atomic

        [BinaryTypeInt(32)]
        public Int32 Value { get => _Value; set => _Value = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public Int32? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public Int32? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int32 ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int32? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int32? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int32?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32>? List { get => _List; set => _List = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeInt(32, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int32?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override Int32? _GetRandomNullableValue() => RandomHandler.GetNextInt32Nullable();

        protected override Int32 _GetRandomValue() => RandomHandler.GetNextInt32();
    }
}
