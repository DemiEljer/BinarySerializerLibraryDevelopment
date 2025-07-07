using BenchmarkDotNet.Running;
using Benchmarks.Tests;
using BinarySerializerLibraryTests.Base;

namespace Benchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomHandler.SetRandomSeed(0);

            Scenario1();
        }

        public static void Scenario1()
        {
            Scenario1ModelsBenchmarks.PrintInformation();

            Scenario1ModelsBenchmarks.CustomBenchmark();
            //BenchmarkRunner.Run<Scenario1ModelsBenchmarks>();

            Scenario1ModelsBenchmarks.PrintInformation();
        }

        public static void Scenario2()
        {
            Scenario2ModelsBenchmarks.PrintInformation();

            Scenario2ModelsBenchmarks.CustomBenchmark();
            //BenchmarkRunner.Run<Scenario2ModelsBenchmarks>();

            Scenario2ModelsBenchmarks.PrintInformation();
        }
    }
}
