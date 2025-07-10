using BinarySerializerLibrary;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.CorrectModels;
using BinarySerializerLibraryTests.Models;

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

        Helpers.CheckExceptionHasNotThrown(() => stringDescriptions = BinarySerializer.GetTypesDescriptionsStringExceptionThrowing());

        Assert.IsFalse(string.IsNullOrEmpty(stringDescriptions));

        using (StreamWriter sw = new StreamWriter("descriptions.txt"))
        {
            sw.Write(stringDescriptions);
        }

        Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.ApplyTypesDescriptionsExceptionThrowing(stringDescriptions));

        var binaryDescriptions = Array.Empty<byte>();

        Helpers.CheckExceptionHasNotThrown(() => binaryDescriptions = BinarySerializer.GetTypesDescriptionsBinaryExceptionThrowing());

        Assert.IsNotNull(binaryDescriptions);
        Assert.IsFalse(binaryDescriptions.Length == 0);

        Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.ApplyTypesDescriptionsExceptionThrowing(binaryDescriptions));
    }
}
