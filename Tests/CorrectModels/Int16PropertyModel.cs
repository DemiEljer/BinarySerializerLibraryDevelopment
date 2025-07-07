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
    public class Int16PropertyModel : BasePropertyModel<Int16>, IBasePropertyModel<Int16>
    {
        #region Atomic

        [BinaryTypeInt(16)]
        public Int16 Value { get => _Value; set => _Value = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public Int16? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public Int16? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int16 ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int16? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int16? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public Int16?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16>? List { get => _List; set => _List = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeInt(16, BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<Int16?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override Int16? _GetRandomNullableValue() => RandomHandler.GetNextInt16Nullable();

        protected override Int16 _GetRandomValue() => RandomHandler.GetNextInt16();
    }
}
