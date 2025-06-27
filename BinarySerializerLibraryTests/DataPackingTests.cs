using BinarySerializerLibrary;
using BinarySerializerLibrary.Exceptions;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.TestModels;

namespace BinarySerializerLibraryTests;

[TestClass]
public class DataPackingTests
{
    [TestMethod]
    public void ModelPackingTest()
    {
        foreach (var index in Enumerable.Range(0, 1000))
        {
            TestPackingModel model = TestPackingModel.Create();

            var serializedData = BinarySerializer.SerializeExceptionThrowing(model);
            // Ручная упаковка модели
#pragma warning disable CS8629 // Тип значения, допускающего NULL, может быть NULL.
            var targetData = new byte[]
            {
                (byte)(0x0B << 1)
                , (byte)(0)
                , (byte)(0x01 | (model.ByteField1 << 1))
                , (byte)(model.ByteField2)
                , (byte)((model.ByteField3 is null ? 0x00 : 0x01) | (model.ByteField3 is null ? 0x00 : model.ByteField3) << 1)
                , (byte)((model.ByteField4 is null ? 0x00 : 0x01) | (model.ByteField4 is null ? 0x00 : model.ByteField4) << 1)
                , (byte)(0x01)
                , (byte)((model.ByteFieldArray.Length << 2))
                , (byte)((model.ByteFieldArray[0] is null ? 0x00 : 0x01) | (model.ByteFieldArray[0] is null ? 0x00 : model.ByteFieldArray[0]) << 1)
                , (byte)((model.ByteFieldArray[1] is null ? 0x00 : 0x01) | (model.ByteFieldArray[1] is null ? 0x00 : model.ByteFieldArray[1]) << 1)
                , (byte)((model.ByteFieldArray[2] is null ? 0x00 : 0x01) | (model.ByteFieldArray[2] is null ? 0x00 : model.ByteFieldArray[2]) << 1)
            };
#pragma warning restore CS8629 // Тип значения, допускающего NULL, может быть NULL.

            Helpers.CheckCollectionsEquality(targetData, serializedData);
        }
    }

    [TestMethod]
    public void PackingTooBigIntAndUIntValuesTest()
    {
        UIntAndIntModel model = new UIntAndIntModel();
        model.UIntField7 = byte.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.UIntField15 = UInt16.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.UIntField31 = UInt32.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.UIntField63 = UInt64.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.UIntField0 = 1;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField7 = sbyte.MinValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField7 = sbyte.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField15 = Int16.MinValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField15 = Int16.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField31 = Int32.MinValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField31 = Int32.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField63 = Int64.MinValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField63 = Int64.MaxValue;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField0 = 1;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));

        model = new UIntAndIntModel();
        model.IntField0 = -1;
        Assert.ThrowsException<TypeTooSmallForValueException>(() => BinarySerializer.SerializeExceptionThrowing(model));
    }
}
