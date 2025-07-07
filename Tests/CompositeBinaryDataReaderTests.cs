using BinarySerializerLibrary;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.Models;

namespace BinarySerializerLibraryTests;

[TestClass]
public class CompositeBinaryDataReaderTests
{
    public static List<byte[]> GetSubSequences(byte[] byteSequence, int subSequencesCount)
    {
        List<byte[]> subSeuqnces = new();

        IEnumerable<byte> _GetSubSequence(byte[] byteSequence, int startIndex, int count)
        {
            foreach (var index in Enumerable.Range(startIndex, count))
            {
                yield return byteSequence[index];
            }
        }

        foreach (var index in Enumerable.Range(0, subSequencesCount))
        {
            int subSequenceSize = index == (subSequencesCount - 1)
                ? byteSequence.Length - byteSequence.Length / subSequencesCount * index
                : byteSequence.Length / subSequencesCount;
            int subSequenceStartIndex = byteSequence.Length / subSequencesCount * index;

            subSeuqnces.Add(_GetSubSequence(byteSequence, subSequenceStartIndex, subSequenceSize).ToArray());
        }

        return subSeuqnces;
    }

    [TestMethod]
    public void ReadingOneObjectFromSeveralReadersTest()
    {
        var originModel = new ObjectPropertyModel();
        
        var serializedContent = BinarySerializer.SerializeExceptionShielding(originModel);

        // Выделение нескольких отдельных последовательностей из одной общей
        List<byte[]> subSerializedContents = GetSubSequences(serializedContent, 10);

        Assert.IsTrue(subSerializedContents.Sum(subSequence => subSequence.Length) == serializedContent.Length);

        CompositeBinaryDataReader compositeReader = new();

        // Проверка, что невозможно прочитать объект из половины последовательностей
        foreach (var index in Enumerable.Range(0, 5))
        {
            compositeReader.AppendReader(new BinaryArrayReader(subSerializedContents[index]));
        }

        Assert.IsFalse(compositeReader.IsEndOfCollection);
        Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectSizeCanBeRead(compositeReader));
        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectCanBeRead(compositeReader));

        foreach (var index in Enumerable.Range(5, 5))
        {
            compositeReader.AppendReader(new BinaryArrayReader(subSerializedContents[index]));
        }

        Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectSizeCanBeRead(compositeReader));
        Assert.IsTrue(BinarySerializer.CheckIfSerializedObjectCanBeRead(compositeReader));

        Helpers.CheckExceptionHasNotThrown((eh) =>
        {
            var deserializedObject = BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader, eh);

            originModel.AssetEqual(deserializedObject);
        });

        Assert.IsTrue(compositeReader.IsEndOfCollection);
        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectSizeCanBeRead(compositeReader));
        Assert.IsFalse(BinarySerializer.CheckIfSerializedObjectCanBeRead(compositeReader));
    }

    [TestMethod]
    public void BitIndexChangingTest()
    {
        CompositeBinaryDataReader compositeReader = new();

        int oneArraySize = 100;
        int arraysCount = 10;

        foreach (var index in Enumerable.Range(0, arraysCount))
        {
            compositeReader.AppendReader(new BinaryArrayReader(new byte[oneArraySize]));
        }

        var simpleBinaryReaders = compositeReader.Readers.ToArray();

        void _TestBitIndexSetting(int index)
        {
            compositeReader.SetBitIndex(index);

            int targetUsingBinaryReaderIndex = index / 100;
            int targetUsingBinaryReaderBitIndex = index % 100;

            foreach (var readerIndex in Enumerable.Range(0, simpleBinaryReaders.Length))
            {
                if (readerIndex == targetUsingBinaryReaderIndex)
                {
                    Assert.AreEqual(targetUsingBinaryReaderBitIndex, simpleBinaryReaders[readerIndex].BitIndex);
                }
                else
                {
                    Assert.AreEqual(0, simpleBinaryReaders[readerIndex].BitIndex);
                }

            }
        }

        foreach (var index in Enumerable.Range(0, 1000))
        {
            _TestBitIndexSetting(RandomHandler.GetNextCollectionSize() % (oneArraySize + arraysCount + 1));
        }
    }

    [TestMethod]
    public void SimpleReadersAppendingTest()
    {
        CompositeBinaryDataReader compositeReader = new();

        var originModel = new ObjectPropertyModel();

        var serializedContent = BinarySerializer.SerializeExceptionShielding(originModel);

        // Последовательное добавление и чтение
        {
            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            Assert.AreEqual(0, compositeReader.ByteIndex);

            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 1, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);

            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 2, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);

            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 3, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);

            compositeReader.RemovePassedReaders();
            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);

            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 1, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);

            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 2, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);

            compositeReader.RemovePassedReaders();
            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);
            Assert.AreEqual(0, compositeReader.Readers.Count());
        }
        // Добавление, а затем последовательное чтение с удалением прочитанных фрагментов
        {
            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsFalse(compositeReader.IsEndOfCollection);

            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsFalse(compositeReader.IsEndOfCollection);

            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 1, compositeReader.ByteIndex);

            compositeReader.RemovePassedReaders();
            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsFalse(compositeReader.IsEndOfCollection);

            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            Assert.AreEqual(serializedContent.Length * 1, compositeReader.ByteIndex);

            compositeReader.RemovePassedReaders();
            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);
        }
        // Добавление и чтение с проверкой сброса индекса
        {
            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));

            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));

            compositeReader.ResetBitIndex();

            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));
        }
        // Проверка очистки
        {
            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));
            compositeReader.AppendReader(new BinaryArrayReader(serializedContent));

            originModel.AssetEqual(BinarySerializer.DeserializeExceptionShielding<ObjectPropertyModel>(compositeReader));

            compositeReader.Clear();

            Assert.AreEqual(0, compositeReader.ByteIndex);
            Assert.IsTrue(compositeReader.IsEndOfCollection);
        }
    }
}
