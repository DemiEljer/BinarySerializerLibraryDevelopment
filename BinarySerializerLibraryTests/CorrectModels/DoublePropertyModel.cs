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
    public class DoublePropertyModel : BasePropertyModel<double>, IBasePropertyModel<double>
    {
        #region Atomic

        [BinaryTypeDouble()]
        public double Value { get => _Value; set => _Value = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public double? ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable)]
        public double? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public double ValueAlignment { get => _ValueAlignment; set => _ValueAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public double? ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public double? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double?[]? NullableArray { get => _NullableArray; set => _NullableArray = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public double?[]? NullableArrayAlignment { get => _NullableArrayAlignment; set => _NullableArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double>? List { get => _List; set => _List = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double?>? NullableList { get => _NullableList; set => _NullableList = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        [BinaryTypeDouble(BinarySerializerLibrary.Enums.BinaryNullableTypeEnum.Nullable, BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<double?>? NullableListAlignment { get => _NullableListAlignment; set => _NullableListAlignment = value; }

        #endregion List

        protected override double _GetRandomValue() => RandomHandler.GetNextDouble();

        protected override double? _GetRandomNullableValue() => RandomHandler.GetNextDoubleNullable();
    }
}
