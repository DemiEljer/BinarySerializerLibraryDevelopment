using BinarySerializerLibrary;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibrary.Exceptions;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.IncorrectModels;
using BinarySerializerLibraryTests.Models;

namespace BinarySerializerLibraryTests;

[TestClass]
public class IncorrectModelsTests
{
    [TestMethod]
    public void ModelWithIncorrectPropertyAttributeTest()
    {
        _VerifyModelTypeCooking<ModelWithIncorrectPropertyAttribute>();
        _VerifyModelModelSerialization<ModelWithIncorrectPropertyAttribute>();
    }

    [TestMethod]
    public void ModelWithNoneObjectivePropertyTest()
    {
        _VerifyModelTypeCooking<ModelWithNoneObjectiveProperty>();
        _VerifyModelModelSerialization<ModelWithIncorrectPropertyAttribute>();
    }

    [TestMethod]
    public void ModelWithNonePublicPropertyTest()
    {
        _VerifyModelTypeCooking<ModelWithNonePublicProperty>();
        _VerifyModelModelSerialization<ModelWithIncorrectPropertyAttribute>();
    }

    [TestMethod]
    public void ModelWithoutAttributeTest()
    {
        _VerifyModelTypeCooking<ModelWithoutAttribute>();
        _VerifyModelModelSerialization<ModelWithIncorrectPropertyAttribute>();
    }

    [TestMethod]
    public void NonePublicModelTest()
    {
        _VerifyModelTypeCooking<NonePublicModel>();
        _VerifyModelModelSerialization<ModelWithIncorrectPropertyAttribute>();
    }

    [TestMethod]
    public void ModelWithoutDefaultConstructorTest()
    {
        _VerifyModelTypeCooking<ModelWithoutDefaultConstructor>();

        // Попытки сериализации
        {
            var model = new ModelWithoutDefaultConstructor(1);

            Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.SerializeExceptionShielding(model, eh));

            Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.SerializeExceptionThrowing(model));
        }
    }

    [TestMethod]
    public void ModelNoneClassTest()
    {
        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.CookObjectRecipeExceptionShielding(typeof(ModelNoneClass), eh));

        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.CookObjectRecipeExceptionThrowing(typeof(ModelNoneClass)));
    }

    [TestMethod]
    public void AllDeserializeMethodsTest()
    {
        ModelWithIncorrectPropertyAttribute originModel = new ModelWithIncorrectPropertyAttribute();
        byte[]? serializedData = null;
        object? deserializedObject = null;

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => serializedData = BinarySerializer.SerializeExceptionShielding(originModel, eh));

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => 
            deserializedObject = BinarySerializer.DeserializeExceptionShielding<ModelWithIncorrectPropertyAttribute>(serializedData, eh));

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => 
            deserializedObject = BinarySerializer.DeserializeExceptionShielding(serializedData, typeof(ModelWithIncorrectPropertyAttribute), eh));

        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.DeserializeExceptionThrowing<ModelWithIncorrectPropertyAttribute>(serializedData));
        
        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.DeserializeExceptionThrowing(serializedData, typeof(ModelWithIncorrectPropertyAttribute)));

        BinaryArrayReader ar = new BinaryArrayReader(serializedData);

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) =>
            deserializedObject = BinarySerializer.DeserializeExceptionShielding<ModelWithIncorrectPropertyAttribute>(ar, eh));

        ar.ResetBitIndex();

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) =>
            deserializedObject = BinarySerializer.DeserializeExceptionShielding(ar, typeof(ModelWithIncorrectPropertyAttribute), eh));

        ar.ResetBitIndex();

        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => deserializedObject = BinarySerializer.DeserializeExceptionThrowing<ModelWithIncorrectPropertyAttribute>(ar));

        ar.ResetBitIndex();

        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => deserializedObject = BinarySerializer.DeserializeExceptionThrowing(ar, typeof(ModelWithIncorrectPropertyAttribute)));

        Assert.IsNull(deserializedObject);
    }

    private void _VerifyModelTypeCooking<ModelType>()
        where ModelType : class
    {
        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.CookObjectRecipeExceptionShielding(typeof(ModelType), eh));
        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.CookObjectRecipeExceptionShielding<ModelType>(eh));

        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.CookObjectRecipeExceptionThrowing(typeof(ModelType)));
        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.CookObjectRecipeExceptionThrowing<ModelType>());
    }

    private void _VerifyModelModelSerialization<ModelType>()
        where ModelType : class
    {
        var model = Activator.CreateInstance(typeof(ModelType));

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.SerializeExceptionShielding(model, eh));

        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.SerializeExceptionThrowing(model));
    }
}
