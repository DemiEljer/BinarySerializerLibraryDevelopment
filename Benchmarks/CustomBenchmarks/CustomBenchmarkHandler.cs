using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.CustomBenchmarks
{
    public static class CustomBenchmarkHandler
    {
        public static double Benchmark(Action benchmarkDelegate)
        {
            if (benchmarkDelegate is null)
            {
                throw new ArgumentNullException(nameof(benchmarkDelegate));
            }

            DateTime timemark = DateTime.Now;

            benchmarkDelegate?.Invoke();

            return (double)(DateTime.Now - timemark).Ticks / (double)TimeSpan.TicksPerMillisecond;
        }

        public static double[] Benchmark(int iterationsCount, Action benchmarkDelegate, Action<int, double>? callback = null)
        {
            if (iterationsCount < 0)
            {
                throw new ArgumentException(nameof(iterationsCount));
            }

            double[] resultTimeSpans = new double[iterationsCount];

            foreach (var iterationIndex in Enumerable.Range(0, iterationsCount))
            {
                resultTimeSpans[iterationIndex] = Benchmark(benchmarkDelegate);

                callback?.Invoke(iterationIndex, resultTimeSpans[iterationIndex]);
            }

            return resultTimeSpans;
        }

        public static double BenchmarkAndPrintResult(string testName, int iterationsCount, Action benchmarkDelegate)
        {
            Console.WriteLine($"Test \"{testName} has started\"");

            double result = Benchmark(iterationsCount, benchmarkDelegate, (i, t) => Console.WriteLine($"[{i}] :: {t} ms")).Sum() / (double)iterationsCount;

            Console.WriteLine($"{testName} [{iterationsCount}] :: {result} ms");

            return result;
        }
    }
}
