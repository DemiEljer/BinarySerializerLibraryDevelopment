using BinarySerializerLibrary;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibrary.Exceptions;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Models;
using System;

namespace BinarySerializerLibraryTests;

[TestClass]
public class BounderyConditionsBinarySerializationInvoke
{
    [TestMethod]
    public void SerializationInvokeForPluralObjects()
    {
        BinaryArrayBuilder ab = new();

        List<(Type modelType, object modelObject)> originModels = new();
        List<int> modelSizes = new();

        originModels.Add((typeof(BoolPropertyModel), new BoolPropertyModel()));
        originModels.Add((typeof(BytePropertyModel), new BytePropertyModel()));
        originModels.Add((typeof(CharPropertyModel), new CharPropertyModel()));
        originModels.Add((typeof(DoublePropertyModel), new DoublePropertyModel()));
        originModels.Add((typeof(FloatPropertyModel), new FloatPropertyModel()));
        originModels.Add((typeof(Int16PropertyModel), new Int16PropertyModel()));
        originModels.Add((typeof(Int32PropertyModel), new Int32PropertyModel()));
        originModels.Add((typeof(Int64PropertyModel), new Int64PropertyModel()));
        originModels.Add((typeof(ObjectPropertyModel), new ObjectPropertyModel()));
        originModels.Add((typeof(SBytePropertyModel), new SBytePropertyModel()));
        originModels.Add((typeof(StringPropertyModel), new StringPropertyModel()));
        originModels.Add((typeof(UInt16PropertyModel), new UInt16PropertyModel()));
        originModels.Add((typeof(UInt32PropertyModel), new UInt32PropertyModel()));
        originModels.Add((typeof(UInt64PropertyModel), new UInt64PropertyModel()));

        long prevSerializedVectorSize = 0;
        foreach (var index in Enumerable.Range(0, originModels.Count))
        {
            BinarySerializer.SerializeExceptionShielding(ab, originModels[index].modelObject);
            modelSizes.Add((int)(ab.BytesCount - prevSerializedVectorSize));
            prevSerializedVectorSize = ab.BytesCount;
        }

        BinaryArrayReader ar = new(ab.GetByteArray());

        foreach (var index in Enumerable.Range(0, originModels.Count))
        {
            Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectSizeCanBeRead(ar));
            Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectCanBeRead(ar));
            Assert.IsNotNull(BinarySerializer.GetSerializedObjectSize(ar));
            Assert.AreEqual(modelSizes[index], BinarySerializer.GetSerializedObjectSize(ar));

            var method = originModels[index].modelType.GetMethod("AssetEqual");
            Assert.IsNotNull(method);
            method.Invoke(originModels[index].modelObject, new object?[] { BinarySerializer.DeserializeExceptionShielding(ar, originModels[index].modelType) });
        }

        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectCanBeRead(ar));
        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectCanBeRead(ar));
        Assert.IsNull(BinarySerializer.GetSerializedObjectSize(ar));

        ar.ResetBitIndex();
    }

    [TestMethod]
    public void SerializationInvokeForPluralObjectsWithNullObjects()
    {
        BinaryArrayBuilder ab = new();

        List<(Type modelType, object? modelObject)> originModels = new();
        List<int> modelSizes = new();

        originModels.Add((typeof(BoolPropertyModel), new BoolPropertyModel()));
        originModels.Add((typeof(BytePropertyModel), null));
        originModels.Add((typeof(CharPropertyModel), new CharPropertyModel()));
        originModels.Add((typeof(DoublePropertyModel), null));
        originModels.Add((typeof(FloatPropertyModel), new FloatPropertyModel()));
        originModels.Add((typeof(Int16PropertyModel), null));
        originModels.Add((typeof(Int32PropertyModel), new Int32PropertyModel()));
        originModels.Add((typeof(Int64PropertyModel), null));
        originModels.Add((typeof(ObjectPropertyModel), new ObjectPropertyModel()));
        originModels.Add((typeof(SBytePropertyModel), null));
        originModels.Add((typeof(StringPropertyModel), new StringPropertyModel()));
        originModels.Add((typeof(UInt16PropertyModel), null));
        originModels.Add((typeof(UInt32PropertyModel), new UInt32PropertyModel()));
        originModels.Add((typeof(UInt64PropertyModel), null));

        int prevSerializedVectorSize = 0;
        foreach (var index in Enumerable.Range(0, originModels.Count))
        {
            BinarySerializer.SerializeExceptionShielding(ab, originModels[index].modelObject);
            modelSizes.Add((int)(ab.BytesCount - prevSerializedVectorSize));
            prevSerializedVectorSize = (int)(ab.BytesCount);
        }

        BinaryArrayReader ar = new(ab.GetByteArray());

        foreach (var index in Enumerable.Range(0, originModels.Count))
        {
            Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectSizeCanBeRead(ar));
            Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectCanBeRead(ar));
            Assert.IsNotNull(BinarySerializer.GetSerializedObjectSize(ar));
            Assert.AreEqual(modelSizes[index], BinarySerializer.GetSerializedObjectSize(ar));

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding(ar, originModels[index].modelType);

            if (originModels[index].modelObject is null)
            {
                Assert.IsNull(deserializedObject);
            }
            else
            {
                var method = originModels[index].modelType.GetMethod("AssetEqual");
                Assert.IsNotNull(method);
                method.Invoke(originModels[index].modelObject, new object?[] { deserializedObject });
            }
        }

        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectCanBeRead(ar));
        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectCanBeRead(ar));
        Assert.IsNull(BinarySerializer.GetSerializedObjectSize(ar));

        ar.ResetBitIndex();
    }

    [TestMethod]
    public void SerializationInvokeWithNullObject()
    {
        var serializedData = BinarySerializer.SerializeExceptionShielding<BoolPropertyModel>(null);

        Assert.IsNotNull(serializedData);
        Assert.IsTrue(serializedData.Length == 2);
        Assert.AreEqual(4, serializedData[0]);
        Assert.AreEqual(0, serializedData[1]);

        serializedData = BinarySerializer.SerializeExceptionThrowing<BoolPropertyModel>(null);

        Assert.IsNotNull(serializedData);
        Assert.IsTrue(serializedData.Length == 2);
        Assert.AreEqual(4, serializedData[0]);
        Assert.AreEqual(0, serializedData[1]);

        serializedData = BinarySerializer.SerializeExceptionShielding(null);

        Assert.IsNotNull(serializedData);
        Assert.IsTrue(serializedData.Length == 2);
        Assert.AreEqual(4, serializedData[0]);
        Assert.AreEqual(0, serializedData[1]);

        serializedData = BinarySerializer.SerializeExceptionThrowing(null);

        Assert.IsNotNull(serializedData);
        Assert.IsTrue(serializedData.Length == 2);
        Assert.AreEqual(4, serializedData[0]);
        Assert.AreEqual(0, serializedData[1]);
    }

    [TestMethod]
    public void SerializationInvokeWithNullBuilder()
    {
#pragma warning disable CS8625 // Ћитерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        Helpers.CheckExceptionHasThrown<BinaryWriterIsNullException>((eh) => BinarySerializer.SerializeExceptionShielding<object>(null, null, eh));

        Assert.ThrowsException<BinaryWriterIsNullException>(() => BinarySerializer.SerializeExceptionThrowing<object>(null, null));
#pragma warning restore CS8625 // Ћитерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
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

#pragma warning disable CS8604 // ¬озможно, аргумент-ссылка, допускающий значение NULL.
        Helpers.CheckExceptionHasThrown<BinaryReaderIsNullException>((eh) => BinarySerializer.DeserializeExceptionShielding<object>(binaryReader, eh));

        Assert.ThrowsException<BinaryReaderIsNullException>(() => BinarySerializer.DeserializeExceptionThrowing<object>(binaryReader));
#pragma warning restore CS8604 // ¬озможно, аргумент-ссылка, допускающий значение NULL.
    }

    [TestMethod]
    public void CookingUnsuitableObjectsTest()
    {
        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.CookObjectRecipeExceptionThrowing(typeof(object)));
        Assert.ThrowsException<ObjectTypeVerificationFailedException>(() => BinarySerializer.CookObjectRecipeExceptionThrowing<object>());

        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.CookObjectRecipeExceptionShielding(typeof(object), eh));
        Helpers.CheckExceptionHasThrown<ObjectTypeVerificationFailedException>((eh) => BinarySerializer.CookObjectRecipeExceptionShielding<object>(eh));
    }

    public void TypeRegisterForAutoSerializationTest()
    {
        // –егистраци€ двух одинаковых типов с одним кодом
        {
            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing<CharPropertyModel>(10));
            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(CharPropertyModel), 10));
        }
        // ѕереназначение кода типу
        {
            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing<CharPropertyModel>(21));
            Assert.AreEqual(21, BinarySerializer.GetRegisteredTypesForAutoSerialization().FirstOrDefault(tp => tp.ObjectType == typeof(CharPropertyModel))?.ObjectTypeCode);
        }
        // –егистраци€ двух одинаковых типов с разными кодами
        {
            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing<SBytePropertyModel>(11));
            Assert.ThrowsException<UnavailablePairOfTypeAndCodeException>(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(SBytePropertyModel), 12));
        }
        // –егистраци€ двух разных типов с одинаковым кодом
        {
            Helpers.CheckExceptionHasNotThrown(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing<UInt16PropertyModel>(13));
            Assert.ThrowsException<UnavailablePairOfTypeAndCodeException>(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(UInt32PropertyModel), 14));
        }
        // –егистраци€ типа с нулевым кодом
        {
            Assert.ThrowsException<UnavailablePairOfTypeAndCodeException>(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(BytePropertyModel), 0));
        }
        // –егистраци€ типа со слишком большим кодом
        {
            Assert.ThrowsException<UnavailablePairOfTypeAndCodeException>(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(BytePropertyModel), 0x40000000));
        }
        // –егистраци€ пустого типа
        {
            Assert.ThrowsException<UnavailablePairOfTypeAndCodeException>(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(null, 15));
        }
        // –егистраци€ неподход€щего типа
        {
            Assert.ThrowsException<UnavailablePairOfTypeAndCodeException>(() => BinarySerializer.RegisterTypeForAutoSerializationExceptionThrowing(typeof(List<int>), 15));
        }
    }

}
