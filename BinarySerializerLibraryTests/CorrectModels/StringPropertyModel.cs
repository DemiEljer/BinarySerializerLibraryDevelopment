using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Models
{
    [BinarySerializableObject]
    public class StringPropertyModel : ObjectiveBasePropertyModel<string>, IObjectiveBasePropertyModel<string>
    {
        #region Atomic

        [BinaryTypeString()]
        public string ValueEmpty { get; set; } = "";

        [BinaryTypeString()]
        public string ValueNotNull { get => _ValueNotNull; set => _ValueNotNull = value; }

        [BinaryTypeString()]
        public string? ValueNull { get => _ValueNull; set => _ValueNull = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public string ValueNotNullAlignment { get => _ValueNotNullAlignment; set => _ValueNotNullAlignment = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public string? ValueNullAlignment { get => _ValueNullAlignment; set => _ValueNullAlignment = value; }

        #endregion Atomic

        #region Array

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public string[]? NullArray { get => _NullArray; set => _NullArray = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public string[]? EmptyArray { get => _EmptyArray; set => _EmptyArray = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public string?[]? Array { get => _Array; set => _Array = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public string[]? NullArrayAlignment { get => _NullArrayAlignment; set => _NullArrayAlignment = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public string[]? EmptyArrayAlignment { get => _EmptyArrayAlignment; set => _EmptyArrayAlignment = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.Array)]
        public string?[]? ArrayAlignment { get => _ArrayAlignment; set => _ArrayAlignment = value; }

        #endregion Array

        #region List

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<string>? NullList { get => _NullList; set => _NullList = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<string>? EmptyList { get => _EmptyList; set => _EmptyList = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<string?>? List { get => _List; set => _List = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<string>? NullListAlignment { get => _NullListAlignment; set => _NullListAlignment = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<string>? EmptyListAlignment { get => _EmptyListAlignment; set => _EmptyListAlignment = value; }

        [BinaryTypeString(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment, BinarySerializerLibrary.Enums.BinaryArgumentTypeEnum.List)]
        public List<string?>? ListAlignment { get => _ListAlignment; set => _ListAlignment = value; }

        #endregion List

        protected override string _GetRandomValue() => RandomHandler.GetNextString(500, 0);

        protected override string? _GetRandomNullableValue() => RandomHandler.GetNextStringNullable(500, 0);

        public override void AssetEqual(ObjectiveBasePropertyModel<string>? anotherModel)
        {
            base.AssetEqual(anotherModel);

            Assert.AreEqual("", ValueEmpty);
            Assert.AreEqual(ValueEmpty, (anotherModel as StringPropertyModel)?.ValueEmpty);
        }
    }
}
