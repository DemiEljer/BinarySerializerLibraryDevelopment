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
    public class BoolPropertyModel : BasePropertyModel<bool>, IBasePropertyModel<bool>
    {
        #region Atomic

        [BinaryTypeBool()]
        public bool Value { get => _Value; set => _Value = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public bool? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public bool? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public bool ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public bool? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public bool? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public bool?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool>? List { get => _List; set => _List = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeBool(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<bool?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override bool _GetRandomValue() => RandomHandler.GetNextBool();

        protected override bool? _GetRandomNullableValue() => RandomHandler.GetNextBoolNullable();
    }
}
