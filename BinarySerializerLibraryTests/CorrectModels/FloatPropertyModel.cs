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
    public class FloatPropertyModel : BasePropertyModel<float>, IBasePropertyModel<float>
    {
        #region Atomic

        [BinaryTypeFloat()]
        public float Value { get => _Value; set => _Value = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public float? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public float? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public float ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public float? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public float? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public float?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float>? List { get => _List; set => _List = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeFloat(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<float?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override float _GetRandomValue() => RandomHandler.GetNextFloat();

        protected override float? _GetRandomNullableValue() => RandomHandler.GetNextFloatNullable();
    }
}
