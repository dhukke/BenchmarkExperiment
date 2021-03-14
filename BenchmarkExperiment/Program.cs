using BenchmarkDotNet.Running;

namespace BenchmarkExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}
