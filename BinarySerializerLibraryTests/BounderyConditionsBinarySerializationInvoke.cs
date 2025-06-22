using BinarySerializerLibrary;
using BinarySerializerLibrary.Base;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Models;

namespace BinarySerializerLibraryTests;

[TestClass]
public class BounderyConditionsBinarySerializationInvoke
{
    [TestMethod]
    public void SerializationInvokeForPluralObjects()
    {
        BinaryArrayBuilder ab = new();

        BoolPropertyModel originModelBool = new();
        BytePropertyModel originModelByte = new();
        CharPropertyModel originModelChar = new();
        DoublePropertyModel originModelDouble = new();
        FloatPropertyModel originModelFloat = new();
        Int16PropertyModel originModelInt16 = new();
        Int32PropertyModel originModelInt32 = new();
        Int64PropertyModel originModelInt64 = new();
        ObjectPropertyModel originModelObject = new();
        SBytePropertyModel originModelSByte = new();
        StringPropertyModel originModelString = new();
        UInt16PropertyModel originModelUInt16 = new();
        UInt32PropertyModel originModelUInt32 = new();
        UInt64PropertyModel originModelUInt64 = new();

        BinarySerializer.SerializeExceptionShielding(ab, originModelBool);
        BinarySerializer.SerializeExceptionShielding(ab, originModelByte);
        BinarySerializer.SerializeExceptionShielding(ab, originModelChar);
        BinarySerializer.SerializeExceptionShielding(ab, originModelDouble);
        BinarySerializer.SerializeExceptionShielding(ab, originModelFloat);
        BinarySerializer.SerializeExceptionShielding(ab, originModelInt16);
        BinarySerializer.SerializeExceptionShielding(ab, originModelInt32);
        BinarySerializer.SerializeExceptionShielding(ab, originModelInt64);
        BinarySerializer.SerializeExceptionShielding(ab, originModelObject);
        BinarySerializer.SerializeExceptionShielding(ab, originModelSByte);
        BinarySerializer.SerializeExceptionShielding(ab, originModelString);
        BinarySerializer.SerializeExceptionShielding(ab, originModelUInt16);
        BinarySerializer.SerializeExceptionShielding(ab, originModelUInt32);
        BinarySerializer.SerializeExceptionShielding(ab, originModelUInt64);

        BinaryArrayReader ar = new(ab.GetByteArray());

        originModelBool.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(BoolPropertyModel)) as BoolPropertyModel);
        originModelByte.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(BytePropertyModel)) as BytePropertyModel);
        originModelChar.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(CharPropertyModel)) as CharPropertyModel);
        originModelDouble.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(DoublePropertyModel)) as DoublePropertyModel);
        originModelFloat.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(FloatPropertyModel)) as FloatPropertyModel);
        originModelInt16.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(Int16PropertyModel)) as Int16PropertyModel);
        originModelInt32.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(Int32PropertyModel)) as Int32PropertyModel);
        originModelInt64.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(Int64PropertyModel)) as Int64PropertyModel);
        originModelObject.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(ObjectPropertyModel)) as ObjectPropertyModel);
        originModelSByte.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(SBytePropertyModel)) as SBytePropertyModel);
        originModelString.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(StringPropertyModel)) as StringPropertyModel);
        originModelUInt16.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(UInt16PropertyModel)) as UInt16PropertyModel);
        originModelUInt32.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(UInt32PropertyModel)) as UInt32PropertyModel);
        originModelUInt64.AssetEqual(BinarySerializer.DeserializeExceptionShielding(ar, typeof(UInt64PropertyModel)) as UInt64PropertyModel);

        ar.ResetBitIndex();
    }

    [TestMethod]
    public void SerializationInvokeWithNullObject()
    {
        var serializedData = BinarySerializer.SerializeExceptionShielding<BoolPropertyModel>(null);

        Assert.IsNotNull(serializedData);
        Assert.IsTrue(serializedData.Length == 0);

        serializedData = BinarySerializer.SerializeExceptionThrowing<BoolPropertyModel>(null);

        Assert.IsNotNull(serializedData);
        Assert.IsTrue(serializedData.Length == 0);
    }

    [TestMethod]
    public void SerializationInvokeWithNullBuilder()
    {
        Helpers.CheckExceptionHasThrown<ArgumentNullException>((eh) => BinarySerializer.SerializeExceptionShielding<object>(null, null, eh));

        Assert.ThrowsException<ArgumentNullException>(() => BinarySerializer.SerializeExceptionThrowing<object>(null, null));
    }

    [TestMethod]
    public void DeserializationInvokeWithEmptyArray()
    {
        byte[]? objectContent = Array.Empty<byte>();
        BoolPropertyModel? deserializedObject = null;

        Helpers.CheckExceptionHasNotThrown((eh) => deserializedObject = BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(objectContent, eh));
        Assert.IsNull(deserializedObject);

        Helpers.CheckExceptionHasNotThrown(() => deserializedObject = BinarySerializer.DeserializeExceptionThrowing<BoolPropertyModel>(objectContent));
        Assert.IsNull(deserializedObject);
    }

    [TestMethod]
    public void DeserializationInvokeWithNullArray()
    {
        byte[]? objectContent = null;
        BoolPropertyModel? deserializedObject = null;

        Helpers.CheckExceptionHasNotThrown((eh) => deserializedObject = BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(objectContent, eh));
        Assert.IsNull(deserializedObject);

        Helpers.CheckExceptionHasNotThrown(() => deserializedObject = BinarySerializer.DeserializeExceptionThrowing<BoolPropertyModel>(objectContent));
        Assert.IsNull(deserializedObject);
    }

    [TestMethod]
    public void DeserializationInvokeWithNullReader()
    {
        BinaryArrayReader? binaryReader = null;

        Helpers.CheckExceptionHasThrown<ArgumentNullException>((eh) => BinarySerializer.DeserializeExceptionShielding<object>(binaryReader, eh));

        Assert.ThrowsException<ArgumentNullException>(() => BinarySerializer.DeserializeExceptionThrowing<object>(binaryReader));
    }
}
