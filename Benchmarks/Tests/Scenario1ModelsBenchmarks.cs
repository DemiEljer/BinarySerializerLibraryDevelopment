using BenchmarkDotNet.Attributes;
using Benchmarks.CustomBenchmarks;
using Benchmarks.Models;
using BinarySerializerLibrary;
using BinarySerializerLibrary.Base;
using BinarySerializerLibraryTests.CorrectModels;
using BinarySerializerLibraryTests.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Tests
{
    public class Scenario1ModelsBenchmarks
    {
        public static BenchmarkModel<AutoDetectPropertyModel> AutoModel { get; } = new();
        public static BenchmarkModel<BoolPropertyModel> BoolModel { get; } = new();
        public static BenchmarkModel<BytePropertyModel> ByteModel { get; } = new();
        public static BenchmarkModel<CharPropertyModel> CharModel { get; } = new();
        public static BenchmarkModel<DoublePropertyModel> DoubleModel { get; } = new();
        public static BenchmarkModel<FloatPropertyModel> FloatModel { get; } = new();
        public static BenchmarkModel<Int16PropertyModel> Int16Model { get; } = new();
        public static BenchmarkModel<Int32PropertyModel> Int32Model { get; } = new();
        public static BenchmarkModel<Int64PropertyModel> Int64Model { get; } = new();
        public static BenchmarkModel<ObjectPropertyModel> ObjectModel { get; } = new();
        public static BenchmarkModel<SBytePropertyModel> SByteModel { get; } = new();
        public static BenchmarkModel<StringPropertyModel> StringModel { get; } = new();
        public static BenchmarkModel<UInt16PropertyModel> UInt16Model { get; } = new();
        public static BenchmarkModel<UInt32PropertyModel> UInt32Model { get; } = new();
        public static BenchmarkModel<UInt64PropertyModel> UInt64Model { get; } = new();

        public static void PrintInformation()
        {
            Console.WriteLine("=== Custom serialization ===");
            Console.WriteLine($"{AutoModel.Model.GetType()} :: {AutoModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{BoolModel.Model.GetType()} :: {BoolModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{ByteModel.Model.GetType()} :: {ByteModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{CharModel.Model.GetType()} :: {CharModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{DoubleModel.Model.GetType()} :: {DoubleModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{FloatModel.Model.GetType()} :: {FloatModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{Int16Model.Model.GetType()} :: {Int16Model.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{Int32Model.Model.GetType()} :: {Int32Model.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{Int64Model.Model.GetType()} :: {Int64Model.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{ObjectModel.Model.GetType()} :: {ObjectModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{SByteModel.Model.GetType()} :: {SByteModel.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{UInt16Model.Model.GetType()} :: {UInt16Model.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{UInt32Model.Model.GetType()} :: {UInt32Model.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{UInt64Model.Model.GetType()} :: {UInt64Model.CustomSerializedDataLength} bytes");

            Console.WriteLine("=== JSON serialization === ");
            Console.WriteLine($"{AutoModel.Model.GetType()} :: {AutoModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{BoolModel.Model.GetType()} :: {BoolModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{ByteModel.Model.GetType()} :: {ByteModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{CharModel.Model.GetType()} :: {CharModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{DoubleModel.Model.GetType()} :: {DoubleModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{FloatModel.Model.GetType()} :: {FloatModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{Int16Model.Model.GetType()} :: {Int16Model.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{Int32Model.Model.GetType()} :: {Int32Model.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{Int64Model.Model.GetType()} :: {Int64Model.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{ObjectModel.Model.GetType()} :: {ObjectModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{SByteModel.Model.GetType()} :: {SByteModel.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{UInt16Model.Model.GetType()} :: {UInt16Model.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{UInt32Model.Model.GetType()} :: {UInt32Model.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{UInt64Model.Model.GetType()} :: {UInt64Model.JSonSerializedDataLength} bytes");
        }

        public static void CustomBenchmark() => CustomBenchmarkHandler.CustomBenchmark<Scenario1ModelsBenchmarks>();

        #region Serialize

        #region Custom

        [Benchmark]
        public void AutoModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(AutoModel.Model);
        }

        [Benchmark]
        public void BoolModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(BoolModel.Model);
        }

        [Benchmark]
        public void ByteModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(ByteModel.Model);
        }

        [Benchmark]
        public void CharModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(CharModel.Model);
        }

        [Benchmark]
        public void DoubleModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(DoubleModel.Model);
        }

        [Benchmark]
        public void FloatModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(FloatModel.Model);
        }

        [Benchmark]
        public void Int16Model_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(Int16Model.Model);
        }

        [Benchmark]
        public void Int32Model_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(Int32Model.Model);
        }

        [Benchmark]
        public void Int64Model_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(Int64Model.Model);
        }

        [Benchmark]
        public void ObjectModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(ObjectModel.Model);
        }

        [Benchmark]
        public void SByteModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(SByteModel.Model);
        }

        [Benchmark]
        public void StringModel_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(StringModel.Model);
        }

        [Benchmark]
        public void UInt16Model_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(UInt16Model.Model);
        }

        [Benchmark]
        public void UInt32Model_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(UInt32Model.Model);
        }

        [Benchmark]
        public void UInt64Model_Custom_SerializeBenchmark()
        {
            BinarySerializer.SerializeExceptionThrowing(UInt64Model.Model);
        }

        #endregion Custom

        #region Json

        [Benchmark]
        public void AutoModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(AutoModel.Model);
        }

        [Benchmark]
        public void BoolModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(BoolModel.Model);
        }

        [Benchmark]
        public void ByteModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(ByteModel.Model);
        }

        [Benchmark]
        public void CharModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(CharModel.Model);
        }

        [Benchmark]
        public void DoubleModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(DoubleModel.Model);
        }

        [Benchmark]
        public void FloatModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(FloatModel.Model);
        }

        [Benchmark]
        public void Int16Model_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(Int16Model.Model);
        }

        [Benchmark]
        public void Int32Model_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(Int32Model.Model);
        }

        [Benchmark]
        public void Int64Model_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(Int64Model.Model);
        }

        [Benchmark]
        public void ObjectModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(ObjectModel.Model);
        }

        [Benchmark]
        public void SByteModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(SByteModel.Model);
        }

        [Benchmark]
        public void StringModel_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(StringModel.Model);
        }

        [Benchmark]
        public void UInt16Model_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(UInt16Model.Model);
        }

        [Benchmark]
        public void UInt32Model_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(UInt32Model.Model);
        }

        [Benchmark]
        public void UInt64Model_Json_SerializeBenchmark()
        {
            JsonConvert.SerializeObject(UInt64Model.Model);
        }

        #endregion Json

        #endregion Serialize

        #region Deserialize

        #region Custom

        [Benchmark]
        public void AutoModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(AutoModel.CustomSerializedData, typeof(AutoDetectPropertyModel));
        }

        [Benchmark]
        public void BoolModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(BoolModel.CustomSerializedData, typeof(BoolPropertyModel));
        }

        [Benchmark]
        public void ByteModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(ByteModel.CustomSerializedData, typeof(BytePropertyModel));
        }

        [Benchmark]
        public void CharModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(CharModel.CustomSerializedData, typeof(CharPropertyModel));
        }

        [Benchmark]
        public void DoubleModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(DoubleModel.CustomSerializedData, typeof(DoublePropertyModel));
        }

        [Benchmark]
        public void FloatModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(FloatModel.CustomSerializedData, typeof(FloatPropertyModel));
        }

        [Benchmark]
        public void Int16Model_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(Int16Model.CustomSerializedData, typeof(Int16PropertyModel));
        }

        [Benchmark]
        public void Int32Model_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(Int32Model.CustomSerializedData, typeof(Int32PropertyModel));
        }

        [Benchmark]
        public void Int64Model_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(Int64Model.CustomSerializedData, typeof(Int64PropertyModel));
        }

        [Benchmark]
        public void ObjectModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(ObjectModel.CustomSerializedData, typeof(ObjectPropertyModel));
        }

        [Benchmark]
        public void SByteModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(SByteModel.CustomSerializedData, typeof(SBytePropertyModel));
        }

        [Benchmark]
        public void StringModel_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(StringModel.CustomSerializedData, typeof(StringPropertyModel));
        }

        [Benchmark]
        public void UInt16Model_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(UInt16Model.CustomSerializedData, typeof(UInt16PropertyModel));
        }

        [Benchmark]
        public void UInt32Model_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(UInt32Model.CustomSerializedData, typeof(UInt32PropertyModel));
        }

        [Benchmark]
        public void UInt64Model_Custom_DeserializeBenchmark()
        {
            BinarySerializer.DeserializeExceptionThrowing(UInt64Model.CustomSerializedData, typeof(UInt64PropertyModel));
        }

        #endregion Custom

        #region Json

        [Benchmark]
        public void AutoModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<AutoDetectPropertyModel>(AutoModel.JSonSerializedData);
        }

        [Benchmark]
        public void BoolModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<BoolPropertyModel>(BoolModel.JSonSerializedData);
        }

        [Benchmark]
        public void ByteModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<BytePropertyModel>(ByteModel.JSonSerializedData);
        }

        [Benchmark]
        public void CharModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<CharPropertyModel>(CharModel.JSonSerializedData);
        }

        [Benchmark]
        public void DoubleModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<DoublePropertyModel>(DoubleModel.JSonSerializedData);
        }

        [Benchmark]
        public void FloatModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<FloatPropertyModel>(FloatModel.JSonSerializedData);
        }

        [Benchmark]
        public void Int16Model_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<Int16PropertyModel>(Int16Model.JSonSerializedData);
        }

        [Benchmark]
        public void Int32Model_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<Int32PropertyModel>(Int32Model.JSonSerializedData);
        }

        [Benchmark]
        public void Int64Model_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<Int64PropertyModel>(Int64Model.JSonSerializedData);
        }

        [Benchmark]
        public void ObjectModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<ObjectPropertyModel>(ObjectModel.JSonSerializedData);
        }

        [Benchmark]
        public void SByteModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<SBytePropertyModel>(SByteModel.JSonSerializedData);
        }

        [Benchmark]
        public void StringModel_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<StringPropertyModel>(StringModel.JSonSerializedData);
        }

        [Benchmark]
        public void UInt16Model_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<UInt16PropertyModel>(UInt16Model.JSonSerializedData);
        }

        [Benchmark]
        public void UInt32Model_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<UInt32PropertyModel>(UInt32Model.JSonSerializedData);
        }

        [Benchmark]
        public void UInt64Model_Json_DeserializeBenchmark()
        {
            JsonConvert.DeserializeObject<UInt64PropertyModel>(UInt64Model.JSonSerializedData);
        }

        #endregion Json

        #endregion Deserialize
    }
}
