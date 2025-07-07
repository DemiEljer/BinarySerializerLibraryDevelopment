using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.CorrectModels
{
    [BinarySerializableObject]
    public class AutoDetectPropertyModel
    {
        #region Atomic

        [BinaryTypeAuto()]
        public BoolPropertyModel ValueNotNull { get; set; }

        [BinaryTypeAuto()]
        public BytePropertyModel? ValueNull { get; set; } = null;

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public CharPropertyModel ValueNotNullAlignment { get; set; }

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public DoublePropertyModel? ValueNullAlignment { get; set; } = null;

        #endregion Atomic

        #region Array

        [BinaryTypeAuto()]
        public FloatPropertyModel[]? NullArray { get; set; } = null;

        [BinaryTypeAuto()]
        public Int16PropertyModel[]? EmptyArray { get; set; } = System.Array.Empty<Int16PropertyModel>();

        [BinaryTypeAuto()]
        public Int32PropertyModel?[]? Array { get; set; }

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public Int64PropertyModel[]? NullArrayAlignment { get; set; } = null;

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public SBytePropertyModel[]? EmptyArrayAlignment { get; set; } = System.Array.Empty<SBytePropertyModel>();

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public StringPropertyModel?[]? ArrayAlignment { get; set; }

        #endregion Array

        #region List

        [BinaryTypeAuto()]
        public List<UInt16PropertyModel>? NullList { get; set; } = null;

        [BinaryTypeAuto()]
        public List<UInt32PropertyModel>? EmptyList { get; set; } = new();

        [BinaryTypeAuto()]
        public List<UInt64PropertyModel?>? List { get; set; }

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public List<BoolPropertyModel>? NullListAlignment { get; set; } = null;

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public List<BytePropertyModel>? EmptyListAlignment { get; set; } = new();

        [BinaryTypeAuto(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.ByteAlignment)]
        public List<CharPropertyModel?>? ListAlignment { get; set; }

        #endregion List

        public AutoDetectPropertyModel()
        {
            // Atomic
            {
                ValueNotNull = new();
                ValueNotNullAlignment = new();
            }

            // Array
            {
                Array = Helpers.CreateCollection<Int32PropertyModel>(() =>
                {
                    if (RandomHandler.GetNextBool())
                    {
                        return new();
                    }
                    else
                    {
                        return null;
                    }
                }).ToArray();

                ArrayAlignment = Helpers.CreateCollection<StringPropertyModel>(() =>
                {
                    if (RandomHandler.GetNextBool())
                    {
                        return new();
                    }
                    else
                    {
                        return null;
                    }
                }).ToArray();
            }

            // List
            {
                List = Helpers.CreateCollection<UInt64PropertyModel>(() =>
                {
                    if (RandomHandler.GetNextBool())
                    {
                        return new();
                    }
                    else
                    {
                        return null;
                    }
                }).ToList();

                ListAlignment = Helpers.CreateCollection<CharPropertyModel>(() =>
                {
                    if (RandomHandler.GetNextBool())
                    {
                        return new();
                    }
                    else
                    {
                        return null;
                    }
                }).ToList();
            }
        }

        public virtual void AssetEqual(AutoDetectPropertyModel? anotherModel)
        {
            Assert.IsNotNull(anotherModel);
            // Atomic
            {
                Helpers.CheckIfNotNull(ValueNotNull, anotherModel.ValueNotNull, (_target, _actual) =>
                {
                    _target?.AssetEqual(_actual);
                });
                Helpers.CheckIfNull(ValueNull, anotherModel.ValueNull);

                Helpers.CheckIfNotNull(ValueNotNullAlignment, anotherModel.ValueNotNullAlignment, (_target, _actual) =>
                {
                    _target?.AssetEqual(_actual);
                });
                Helpers.CheckIfNull(ValueNullAlignment, anotherModel.ValueNullAlignment);
            }

            // Array
            {
                Helpers.CheckIfNull(NullArray, anotherModel.NullArray);
                Helpers.CheckIfEmptyCollections(EmptyArray, anotherModel.EmptyArray);
                Helpers.CheckCollectionsEquality(Array, anotherModel.Array, (_target, _actual) =>
                {
                    if (_target is null)
                    {
                        Helpers.CheckIfNull(_target, _actual);
                    }
                    else
                    {
                        _target?.AssetEqual(_actual);
                    }
                });

                Helpers.CheckIfNull(NullArrayAlignment, anotherModel.NullArrayAlignment);
                Helpers.CheckIfEmptyCollections(EmptyArrayAlignment, anotherModel.EmptyArrayAlignment);
                Helpers.CheckCollectionsEquality(ArrayAlignment, anotherModel.ArrayAlignment, (_target, _actual) =>
                {
                    if (_target is null)
                    {
                        Helpers.CheckIfNull(_target, _actual);
                    }
                    else
                    {
                        _target?.AssetEqual(_actual);
                    }
                });
            }

            // List
            {
                Helpers.CheckIfNull(NullList, anotherModel.NullList);
                Helpers.CheckIfEmptyCollections(EmptyList, anotherModel.EmptyList);
                Helpers.CheckCollectionsEquality(List, anotherModel.List, (_target, _actual) =>
                {
                    if (_target is null)
                    {
                        Helpers.CheckIfNull(_target, _actual);
                    }
                    else
                    {
                        _target?.AssetEqual(_actual);
                    }
                });

                Helpers.CheckIfNull(NullListAlignment, anotherModel.NullListAlignment);
                Helpers.CheckIfEmptyCollections(EmptyListAlignment, anotherModel.EmptyListAlignment);
                Helpers.CheckCollectionsEquality(ListAlignment, anotherModel.ListAlignment, (_target, _actual) =>
                {
                    if (_target is null)
                    {
                        Helpers.CheckIfNull(_target, _actual);
                    }
                    else
                    {
                        _target?.AssetEqual(_actual);
                    }
                });
            }
        }
    }
}
