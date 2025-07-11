using BinarySerializerLibrary;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibraryTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests
{
    [TestClass]
    public class BinaryReadersTests
    {
        [TestMethod]
        public void BinaryArrayBuilder_SingleObjectTest()
        {
            BoolPropertyModel originModel = new();

            BinaryArrayBuilder ab = new();

            BinarySerializer.SerializeExceptionShielding(ab, originModel);

            BinaryArrayReader ar = new BinaryArrayReader(ab.GetByteArray());

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(ar);

            originModel.AssetEqual(deserializedObject);

            Assert.IsFalse(ar.CheckIfSerializedObjectCanBeRead());
            Assert.IsTrue(ar.IsEndOfCollection);
        }

        [TestMethod]
        public void BinaryArrayBuilder_PluralObjectsTest()
        {
            CharPropertyModel originModel1 = new();
            SBytePropertyModel originModel2 = new();
            BoolPropertyModel originModel3 = new();

            BinaryArrayBuilder ab = new();

            BinarySerializer.SerializeExceptionShielding(ab, originModel1);
            BinarySerializer.SerializeExceptionShielding(ab, originModel2);
            BinarySerializer.SerializeExceptionShielding(ab, originModel3);

            BinaryArrayReader ar = new BinaryArrayReader(ab.GetByteArray());

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel1.AssetEqual(BinarySerializer.DeserializeExceptionShielding<CharPropertyModel>(ar));

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel2.AssetEqual(BinarySerializer.DeserializeExceptionShielding<SBytePropertyModel>(ar));

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel3.AssetEqual(BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(ar));

            Assert.IsFalse(ar.CheckIfSerializedObjectCanBeRead());
            Assert.IsTrue(ar.IsEndOfCollection);
        }

        [TestMethod]
        public void BinaryArrayBuilder_MethodsTest()
        {
            BinaryArrayBuilder ab = new();

            CharPropertyModel originModel1 = new();
            BinarySerializer.SerializeExceptionShielding(ab, originModel1);

            Assert.IsTrue(ab.BitsCount > 0);
            Assert.IsTrue(ab.BytesCount > 0);
            Assert.AreEqual(ab.BytesCount, ab.GetByteArray().Length);

            ab.Clear();
            Assert.IsTrue(ab.BitsCount == 0);
            Assert.IsTrue(ab.BytesCount == 0);
            Assert.AreEqual(ab.BytesCount, ab.GetByteArray().Length);
        }

        [TestMethod]
        public void BinaryArraySlowBuilder_SingleObjectTest()
        {
            BoolPropertyModel originModel = new();

            BinaryArraySlowBuilder ab = new();

            BinarySerializer.SerializeExceptionShielding(ab, originModel);

            BinaryArrayReader ar = new BinaryArrayReader(ab.GetByteArray());

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(ar);

            originModel.AssetEqual(deserializedObject);

            Assert.IsFalse(ar.CheckIfSerializedObjectCanBeRead());
            Assert.IsTrue(ar.IsEndOfCollection);
        }

        [TestMethod]
        public void BinaryArraySlowBuilder_PluralObjectsTest()
        {
            CharPropertyModel originModel1 = new();
            SBytePropertyModel originModel2 = new();
            BoolPropertyModel originModel3 = new();

            BinaryArraySlowBuilder ab = new();

            BinarySerializer.SerializeExceptionShielding(ab, originModel1);
            BinarySerializer.SerializeExceptionShielding(ab, originModel2);
            BinarySerializer.SerializeExceptionShielding(ab, originModel3);

            BinaryArrayReader ar = new BinaryArrayReader(ab.GetByteArray());

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel1.AssetEqual(BinarySerializer.DeserializeExceptionShielding<CharPropertyModel>(ar));

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel2.AssetEqual(BinarySerializer.DeserializeExceptionShielding<SBytePropertyModel>(ar));

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel3.AssetEqual(BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(ar));

            Assert.IsFalse(ar.CheckIfSerializedObjectCanBeRead());
            Assert.IsTrue(ar.IsEndOfCollection);
        }

        [TestMethod]
        public void BinaryArraySlowBuilder_MethodsTest()
        {
            BinaryArraySlowBuilder ab = new();

            CharPropertyModel originModel1 = new();
            BinarySerializer.SerializeExceptionShielding(ab, originModel1);

            Assert.IsTrue(ab.BitsCount > 0);
            Assert.IsTrue(ab.BytesCount > 0);
            Assert.AreEqual(ab.BytesCount, ab.GetByteArray().Length);

            ab.Clear();
            Assert.IsTrue(ab.BitsCount == 0);
            Assert.IsTrue(ab.BytesCount == 0);
            Assert.AreEqual(ab.BytesCount, ab.GetByteArray().Length);
        }

        [TestMethod]
        public void BinaryArrayFastBuilder_SingleObjectTest()
        {
            BoolPropertyModel originModel = new();

            BinaryArrayFastBuilder ab = new();

            BinarySerializer.SerializeExceptionShielding(ab, originModel);

            BinaryArrayReader ar = new BinaryArrayReader(ab.GetByteArray());

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(ar);

            originModel.AssetEqual(deserializedObject);

            Assert.IsFalse(ar.CheckIfSerializedObjectCanBeRead());
            Assert.IsTrue(ar.IsEndOfCollection);
        }

        [TestMethod]
        public void BinaryArrayFastBuilder_PluralObjectsTest()
        {
            CharPropertyModel originModel1 = new();
            SBytePropertyModel originModel2 = new();
            BoolPropertyModel originModel3 = new();

            BinaryArrayFastBuilder ab = new();

            BinarySerializer.SerializeExceptionShielding(ab, originModel1);
            BinarySerializer.SerializeExceptionShielding(ab, originModel2);
            BinarySerializer.SerializeExceptionShielding(ab, originModel3);

            BinaryArrayReader ar = new BinaryArrayReader(ab.GetByteArray());

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel1.AssetEqual(BinarySerializer.DeserializeExceptionShielding<CharPropertyModel>(ar));

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel2.AssetEqual(BinarySerializer.DeserializeExceptionShielding<SBytePropertyModel>(ar));

            Assert.IsTrue(ar.CheckIfSerializedObjectCanBeRead());

            originModel3.AssetEqual(BinarySerializer.DeserializeExceptionShielding<BoolPropertyModel>(ar));

            Assert.IsFalse(ar.CheckIfSerializedObjectCanBeRead());
            Assert.IsTrue(ar.IsEndOfCollection);
        }

        [TestMethod]
        public void BinaryArrayFastBuilder_MethodsTest()
        {
            BinaryArrayFastBuilder ab = new();

            ab.MinGroupSize = 1;
            Assert.AreEqual(1, ab.MinGroupSize);
            ab.MinGroupSize = 100;
            Assert.AreEqual(100, ab.MinGroupSize);
            ab.MinGroupSize = 0;
            Assert.AreEqual(1, ab.MinGroupSize);
            ab.MinGroupSize = -10;
            Assert.AreEqual(1, ab.MinGroupSize);

            ab.GroupIncreaseFactor = 40.0;
            Assert.AreEqual(40.0, ab.GroupIncreaseFactor);
            ab.GroupIncreaseFactor = 0.0;
            Assert.AreEqual(0.0, ab.GroupIncreaseFactor);
            ab.GroupIncreaseFactor = -2.0;
            Assert.AreEqual(0.0, ab.GroupIncreaseFactor);

            CharPropertyModel originModel1 = new();
            BinarySerializer.SerializeExceptionShielding(ab, originModel1);

            Assert.IsTrue(ab.BitsCount > 0);
            Assert.IsTrue(ab.BytesCount > 0);
            Assert.AreEqual(ab.BytesCount, ab.GetByteArray().Length);

            ab.Clear();
            Assert.IsTrue(ab.BitsCount == 0);
            Assert.IsTrue(ab.BytesCount == 0);
            Assert.AreEqual(ab.BytesCount, ab.GetByteArray().Length);
        }
    }
}
