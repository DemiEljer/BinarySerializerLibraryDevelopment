using BinarySerializerLibrary;
using BinarySerializerLibrary.Attributes;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibrary.Exceptions;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.CorrectModels;
using BinarySerializerLibraryTests.Models;
using BinarySerializerLibraryTests.TestModels;
using Tests.TestModels;

namespace BinarySerializerLibraryTests
{
    [TestClass]
    public sealed class CorrectModelsTests
    {
        [TestMethod]
        public void Bool_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<BoolPropertyModel>();

            BoolPropertyModel originModel = new BoolPropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Char_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<CharPropertyModel>();

            CharPropertyModel originModel = new CharPropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<CharPropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Float_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<FloatPropertyModel>();

            FloatPropertyModel originModel = new FloatPropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<FloatPropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Double_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<DoublePropertyModel>();

            DoublePropertyModel originModel = new DoublePropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<DoublePropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Byte_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<BytePropertyModel>();

            BytePropertyModel originModel = new BytePropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<BytePropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void UInt16_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<UInt16PropertyModel>();

            UInt16PropertyModel originModel = new UInt16PropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<UInt16PropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void UInt32_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<UInt32PropertyModel>();

            UInt32PropertyModel originModel = new UInt32PropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<UInt32PropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void UInt64_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<UInt64PropertyModel>();

            UInt64PropertyModel originModel = new UInt64PropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<UInt64PropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void SByte_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<SBytePropertyModel>();

            SBytePropertyModel originModel = new SBytePropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<SBytePropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Int16_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<Int16PropertyModel>();

            Int16PropertyModel originModel = new Int16PropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<Int16PropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Int32_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<Int32PropertyModel>();

            Int32PropertyModel originModel = new Int32PropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<Int32PropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Int64_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<Int64PropertyModel>();

            Int64PropertyModel originModel = new Int64PropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<Int64PropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void String_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<StringPropertyModel>();

            StringPropertyModel originModel = new StringPropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<StringPropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Object_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<ObjectPropertyModel>();

            ObjectPropertyModel originModel = new ObjectPropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void Auto_SerializationAndDeserializationTest()
        {
            _VerifyModelTypeCooking<AutoDetectPropertyModel>();

            AutoDetectPropertyModel originModel = new AutoDetectPropertyModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<AutoDetectPropertyModel>(serializedData);

            originModel.AssetEqual(deserializedObject);
        }

        [TestMethod]
        public void ManualRecipeCreationModel_SerializationAndDeserializationTest()
        {
            BinarySerializer.CreateObjectRecipeExceptionThrowing<ManualRecipeCreationModel>()
                .AddProperty("Field1", new BinaryTypeIntAttribute(12))
                .AddProperty("Field3", new BinaryTypeAutoAttribute())
                .AddProperty("Field2")
                .Commit(61);

            ManualRecipeCreationModel originModel = new ManualRecipeCreationModel();

            var serializedData = BinarySerializer.SerializeExceptionShielding(originModel);

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<ManualRecipeCreationModel>(serializedData);

            originModel.AssetEqual(deserializedObject);

            // Проверка корректности формирования рецепта
            {
                var manualRecipeCreationModelDescription = BinarySerializer.GetObjectRecipe<ManualRecipeCreationModel>()?.GetDescription();

                Assert.IsNotNull(manualRecipeCreationModelDescription);

                Assert.AreEqual(manualRecipeCreationModelDescription.TypeName, typeof(ManualRecipeCreationModel).FullName);
                Assert.AreEqual(61, manualRecipeCreationModelDescription.TypeCode);
                Assert.AreEqual(61, BinarySerializer.GetRegisteredTypesForAutoSerialization().FirstOrDefault(pair => pair.ObjectType == typeof(ManualRecipeCreationModel))?.ObjectTypeCode);
                Helpers.CheckCollectionsEquality(new string[] { "Field1", "Field3", "Field2" }, manualRecipeCreationModelDescription.PropertiesSequence);
            }


        }

        [TestMethod]
        public void AllSerializeAndDeserailizeMethodsTest()
        {
            ObjectPropertyModel originModel = new ObjectPropertyModel();

            // Static type
            {
                Helpers.CheckExceptionHasNotThrown((eh) =>
                {
                    var serializedContent = BinarySerializer.SerializeExceptionShielding(originModel, eh);

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(serializedContent, eh));
                });

                Helpers.CheckExceptionHasNotThrown((eh) =>
                {
                    BinaryArrayBuilder ab = new();

                    BinarySerializer.SerializeExceptionShielding(ab, originModel, eh);

                    BinaryArrayReader ar = new(ab.GetByteArray());

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(ar, eh));
                });

                Helpers.CheckExceptionHasNotThrown(() =>
                {
                    var serializedContent = BinarySerializer.SerializeExceptionThrowing(originModel);

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionThrowing<ObjectPropertyModel>(serializedContent));
                });

                Helpers.CheckExceptionHasNotThrown(() =>
                {
                    BinaryArrayBuilder ab = new();

                    BinarySerializer.SerializeExceptionThrowing(ab, originModel);

                    BinaryArrayReader ar = new(ab.GetByteArray());

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionThrowing<ObjectPropertyModel>(ar));
                });
            }

            // Dynamic type
            {
                Helpers.CheckExceptionHasNotThrown((eh) =>
                {
                    var serializedContent = BinarySerializer.SerializeExceptionShielding((object)originModel, eh);

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding(serializedContent, typeof(ObjectPropertyModel), eh) as ObjectPropertyModel);
                });

                Helpers.CheckExceptionHasNotThrown((eh) =>
                {
                    BinaryArrayBuilder ab = new();

                    BinarySerializer.SerializeExceptionShielding(ab, (object)originModel, eh);

                    BinaryArrayReader ar = new(ab.GetByteArray());

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(ObjectPropertyModel), eh) as ObjectPropertyModel);
                });

                Helpers.CheckExceptionHasNotThrown(() =>
                {
                    var serializedContent = BinarySerializer.SerializeExceptionThrowing((object)originModel);

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionThrowing(serializedContent, typeof(ObjectPropertyModel)) as ObjectPropertyModel);
                });

                Helpers.CheckExceptionHasNotThrown(() =>
                {
                    BinaryArrayBuilder ab = new();

                    BinarySerializer.SerializeExceptionThrowing(ab, (object)originModel);

                    BinaryArrayReader ar = new(ab.GetByteArray());

                    originModel.AssetEqual(BinarySerializer.DeserializeExceptionThrowing(ar, typeof(ObjectPropertyModel)) as ObjectPropertyModel);
                });
            }

            BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(ObjectPropertyModel), 2);
            // Проверка, что повторное добавление типа под тем же номером не приводит к ошибке
            BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(ObjectPropertyModel), 2);
            // Auto type
            {
                Helpers.CheckExceptionHasNotThrown((eh) =>
                {
                    var serializedContent = BinarySerializer.SerializeExceptionShielding((object)originModel, eh);

                    originModel.AssetEqual(BinarySerializer.AutoDeserializeExceptionShielding(serializedContent, eh) as ObjectPropertyModel);
                });

                Helpers.CheckExceptionHasNotThrown((eh) =>
                {
                    BinaryArrayBuilder ab = new();

                    BinarySerializer.SerializeExceptionShielding(ab, (object)originModel, eh);

                    BinaryArrayReader ar = new(ab.GetByteArray());

                    originModel.AssetEqual(BinarySerializer.AutoDeserializeExceptionShielding(ar, eh) as ObjectPropertyModel);
                });

                Helpers.CheckExceptionHasNotThrown(() =>
                {
                    var serializedContent = BinarySerializer.SerializeExceptionThrowing((object)originModel);

                    originModel.AssetEqual(BinarySerializer.AutoDeserializeExceptionThrowing(serializedContent) as ObjectPropertyModel);
                });

                Helpers.CheckExceptionHasNotThrown(() =>
                {
                    BinaryArrayBuilder ab = new();

                    BinarySerializer.SerializeExceptionThrowing(ab, (object)originModel);

                    BinaryArrayReader ar = new(ab.GetByteArray());

                    originModel.AssetEqual(BinarySerializer.AutoDeserializeExceptionThrowing(ar) as ObjectPropertyModel);
                });
            }
        }


        private void _VerifyModelTypeCooking<ModelType>()
            where ModelType : class
        {
            Helpers.CheckExceptionHasNotThrown((eh) => BinarySerializer.CookObjectRecipeExceptionShielding(typeof(ModelType), eh));
            Helpers.CheckExceptionHasNotThrown((eh) => BinarySerializer.CookObjectRecipeExceptionShielding<ModelType>(eh));

            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.CookObjectRecipeExceptionThrowing(typeof(ModelType)));
            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.CookObjectRecipeExceptionThrowing<ModelType>());
        }
    }
}
