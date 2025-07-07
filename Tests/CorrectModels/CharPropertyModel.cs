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
    public class CharPropertyModel : BasePropertyModel<char>, IBasePropertyModel<char>
    {
        #region Atomic

        [BinaryTypeChar()]
        public char Value { get => _Value; set => _Value = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public char? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public char? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public char ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public char? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public char? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public char?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char>? List { get => _List; set => _List = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeChar(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<char?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override char _GetRandomValue() => RandomHandler.GetNextChar();

        protected override char? _GetRandomNullableValue() => RandomHandler.GetNextCharNullable();
    }
}
