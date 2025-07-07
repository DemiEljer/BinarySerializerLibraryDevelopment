using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarks.CustomBenchmarks;
using Benchmarks.Handlers;
using Benchmarks.Models;
using BinarySerializerLibrary;
using BinarySerializerLibrary.Base;
using BinarySerializerLibrary.BinaryDataHandlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Tests
{
    public class Scenario2ModelsBenchmarks
    {
        public static BenchmarkModel<TestModelLevel2> ModelLevel2 { get; } = new();
        public static BenchmarkModel<TestModelLevel3> ModelLevel3 { get; } = new();
        public static BenchmarkModel<TestModelLevel4> ModelLevel4 { get; } = new();

        public static void PrintInformation()
        {
            Console.WriteLine("=== Custom serialization ===");

            Console.WriteLine($"{ModelLevel2.Model.GetType()} :: {ModelLevel2.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{ModelLevel3.Model.GetType()} :: {ModelLevel3.CustomSerializedDataLength} bytes");
            Console.WriteLine($"{ModelLevel4.Model.GetType()} :: {ModelLevel4.CustomSerializedDataLength} bytes");

            Console.WriteLine("=== JSON serialization === ");

            Console.WriteLine($"{ModelLevel2.Model.GetType()} :: {ModelLevel2.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{ModelLevel3.Model.GetType()} :: {ModelLevel3.JSonSerializedDataLength} bytes");
            Console.WriteLine($"{ModelLevel4.Model.GetType()} :: {ModelLevel4.JSonSerializedDataLength} bytes");
        }

        public static void CustomBenchmark()
        {
            Scenario2ModelsBenchmarks testingScenarioObject = new();

            List<(string testName, double time)> results = new();

            foreach (var method in typeof(Scenario2ModelsBenchmarks).GetMethods())
            {
                double testTime = 0;

                if (method.GetCustomAttributes(true).FirstOrDefault(a => a is BenchmarkAttribute) != null)
                {
                    var methodDelegate = MethodAccessDelegateCompiler.GetMethodDelegate(typeof(Scenario2ModelsBenchmarks), method);
                    var concreteTypeMethodDelegate = methodDelegate as Action<Scenario2ModelsBenchmarks>;

                    if (concreteTypeMethodDelegate is not null)
                    {
                        testTime = CustomBenchmarkHandler.BenchmarkAndPrintResult(method.Name, 100, () =>
                        {
                            concreteTypeMethodDelegate.Invoke(testingScenarioObject);
                        });

                        results.Add((method.Name, testTime));
                    }
                }
            }

            Console.WriteLine("\r\nRESULTS\r\n");

            foreach (var test in results)
            {
                Console.WriteLine($"{test.testName} :: {Math.Round(test.time, 4)} ms");
            }
        }

        #region Level2

        [Benchmark]
        public void Custom_Serialization_ModelLevel2_EmptyBuilder()
        {
            var builder = new BinaryEmptyBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel2.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel2_StandardBuilder()
        {
            var builder = new BinaryArrayBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel2.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel2_FastBuilder()
        {
            var builder = new BinaryArrayFastBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel2.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel2_SlowBuilder()
        {
            var builder = new BinaryArraySlowBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel2.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Json_Serialization_ModelLevel2()
        {
            JsonConvert.SerializeObject(ModelLevel2.Model);
        }
        [Benchmark]
        public void Custom_Deserialization_ModelLevel2()
        {
            BinarySerializer.DeserializeExceptionShielding<TestModelLevel2>(ModelLevel2.CustomSerializedData);
        }
        [Benchmark]
        public void Custom_Deserialization_ModelLevel2_Composite()
        {
            CompositeBinaryDataReader ar = new();
            foreach (var subSequence in ModelLevel2.CustomSubSequencesSerializedData)
            {
                ar.AppendReader(new BinaryArrayReader(subSequence));
            }

            BinarySerializer.DeserializeExceptionShielding<TestModelLevel2>(ar);
        }
        [Benchmark]
        public void Json_Deserialization_ModelLevel2()
        {
            JsonConvert.DeserializeObject<TestModelLevel2>(ModelLevel2.JSonSerializedData);
        }

        #endregion Level2

        #region Level3

        [Benchmark]
        public void Custom_Serialization_ModelLevel3_EmptyBuilder()
        {
            var builder = new BinaryEmptyBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel3.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel3_StandardBuilder()
        {
            var builder = new BinaryArrayBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel3.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel3_FastBuilder()
        {
            var builder = new BinaryArrayFastBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel3.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel3_SlowBuilder()
        {
            var builder = new BinaryArraySlowBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel3.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Json_Serialization_ModelLevel3()
        {
            JsonConvert.SerializeObject(ModelLevel4.Model);
        }
        [Benchmark]
        public void Custom_Deserialization_ModelLevel3()
        {
            BinarySerializer.DeserializeExceptionShielding<TestModelLevel3>(ModelLevel3.CustomSerializedData);
        }
        [Benchmark]
        public void Custom_Deserialization_ModelLevel3_Composite()
        {
            CompositeBinaryDataReader ar = new();
            foreach (var subSequence in ModelLevel3.CustomSubSequencesSerializedData)
            {
                ar.AppendReader(new BinaryArrayReader(subSequence));
            }

            BinarySerializer.DeserializeExceptionShielding<TestModelLevel3>(ar);
        }
        [Benchmark]
        public void Json_Deserialization_ModelLevel3()
        {
            JsonConvert.DeserializeObject<TestModelLevel3>(ModelLevel3.JSonSerializedData);
        }


        #endregion Level3

        #region Level4

        [Benchmark]
        public void Custom_Serialization_ModelLevel4_EmptyBuilder()
        {
            var builder = new BinaryEmptyBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel4.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel4_StandardBuilder()
        {
            var builder = new BinaryArrayBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel4.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel4_FastBuilder()
        {
            var builder = new BinaryArrayFastBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel4.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Custom_Serialization_ModelLevel4_SlowBuilder()
        {
            var builder = new BinaryArraySlowBuilder();

            BinarySerializer.SerializeExceptionShielding(builder, ModelLevel4.Model);

            var data = builder.GetByteArray();
        }
        [Benchmark]
        public void Json_Serialization_ModelLevel4()
        {
            JsonConvert.SerializeObject(ModelLevel4.Model);
        }
        [Benchmark]
        public void Custom_Deserialization_ModelLevel4()
        {
            BinarySerializer.DeserializeExceptionShielding<TestModelLevel4>(ModelLevel4.CustomSerializedData);
        }
        [Benchmark]
        public void Custom_Deserialization_ModelLevel4_Composite()
        {
            CompositeBinaryDataReader ar = new();
            foreach (var subSequence in ModelLevel4.CustomSubSequencesSerializedData)
            {
                ar.AppendReader(new BinaryArrayReader(subSequence));
            }

            BinarySerializer.DeserializeExceptionShielding<TestModelLevel4>(ar);
        }
        [Benchmark]
        public void Json_Deserialization_ModelLevel4()
        {
            JsonConvert.DeserializeObject<TestModelLevel4>(ModelLevel4.JSonSerializedData);
        }

        #endregion Level4

    }
}
