using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkExperiment
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string DateTime = "2019-12-13T16:33:06Z";
        private static readonly DateParser Parser = new();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpanExplictIntConversion()
        {
            Parser.GetYearFromSpanExplictIntConversion(DateTime);
        }
    }
}
