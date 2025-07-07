using BinarySerializerLibrary;
using BinarySerializerLibraryTests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Benchmarks.Models
{
    public class BenchmarkModel<ModelType>
        where ModelType : class, new()
    {
        public ModelType Model { get; } = new();

        public byte[] CustomSerializedData { get; }

        public List<byte[]> CustomSubSequencesSerializedData { get; }

        public int CustomSerializedDataLength => CustomSerializedData is null ? 0 : CustomSerializedData.Length;

        public string JSonSerializedData { get; }

        public int JSonSerializedDataLength => JSonSerializedData is null ? 0 : JSonSerializedData.Length * 2;

        public BenchmarkModel()
        {
            CustomSerializedData = BinarySerializer.SerializeExceptionThrowing(Model);
            CustomSubSequencesSerializedData = CompositeBinaryDataReaderTests.GetSubSequences(CustomSerializedData, 10);
            JSonSerializedData = JsonConvert.SerializeObject(Model);
        }
    }
}
