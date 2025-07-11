using BinarySerializerLibrary;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.CorrectModels;
using BinarySerializerLibraryTests.Models;
using Tests.TestModels;

namespace BinarySerializerLibraryTests;

[TestClass]
public class ObjectTypeDescriptionsTests
{
    [TestMethod]
    public void SavingAndLoadingDescriptionsTest()
    {
        BinarySerializer.CookObjectRecipeExceptionShielding<AutoDetectPropertyModel>();
        BinarySerializer.CookObjectRecipeExceptionShielding<BoolPropertyModel>();
        BinarySerializer.CookObjectRecipeExceptionShielding<BytePropertyModel>();
        BinarySerializer.CookObjectRecipeExceptionShielding<CharPropertyModel>();

        var stringDescriptions = "";

        Helpers.CheckExceptionHasNotThrown(() => stringDescriptions = BinarySerializer.GetTypesDescriptionsString());

        Assert.IsFalse(string.IsNullOrEmpty(stringDescriptions));

        using (StreamWriter sw = new StreamWriter("descriptions.txt"))
        {
            sw.Write(stringDescriptions);
        }

        Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.ApplyTypesDescriptionsExceptionThrowing(stringDescriptions));

        var binaryDescriptions = Array.Empty<byte>();

        Helpers.CheckExceptionHasNotThrown(() => binaryDescriptions = BinarySerializer.GetTypesDescriptionsBinary());

        Assert.IsNotNull(binaryDescriptions);
        Assert.IsFalse(binaryDescriptions.Length == 0);

        Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.ApplyTypesDescriptionsExceptionThrowing(binaryDescriptions));
    }

    [TestMethod]
    public void RecipeChangingByDescriptionTest()
    {
        BinarySerializer.CookObjectRecipeExceptionThrowing<DescriptionChangingModel>();

        var typeRecipe = BinarySerializer.GetObjectRecipe<DescriptionChangingModel>();

        Assert.IsNotNull(typeRecipe);

        var typeDescription = new ObjectTypeDescription(typeRecipe);

        Assert.AreEqual(typeof(DescriptionChangingModel).FullName, typeDescription.TypeName);
        Assert.AreEqual(0, typeDescription.TypeCode);
        Helpers.CheckCollectionsEquality(typeRecipe.PropertiesRecipes.Select(p => p.Property.Name).ToArray(), typeDescription.PropertiesSequence);

        typeDescription.TypeCode = 81;
        typeDescription.PropertiesSequence = new string[] { "Field2", "Field3", "Field1" };
        typeDescription.ApplyDescription();

        Assert.AreEqual(typeDescription.TypeCode, BinarySerializer.GetRegisteredTypesForAutoSerialization().FirstOrDefault(p => p.ObjectType == typeof(DescriptionChangingModel))?.ObjectTypeCode);
        Helpers.CheckCollectionsEquality(typeDescription.PropertiesSequence, typeRecipe.PropertiesRecipes.Select(p => p.Property.Name).ToArray());

        typeDescription.TypeCode = 0;
        typeDescription.PropertiesSequence = new string[] { "Field3", "Field1", "Field2" };
        typeDescription.ApplyDescription();

        Assert.AreEqual(typeDescription.TypeCode, BinarySerializer.GetRegisteredTypesForAutoSerialization().FirstOrDefault(p => p.ObjectType == typeof(DescriptionChangingModel))?.ObjectTypeCode);
        Helpers.CheckCollectionsEquality(typeDescription.PropertiesSequence, typeRecipe.PropertiesRecipes.Select(p => p.Property.Name).ToArray());
    }
}
