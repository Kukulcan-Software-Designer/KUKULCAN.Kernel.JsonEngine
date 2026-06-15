using BenchmarkDotNet.Running;

namespace KUKULCAN.Kernel.JsonEngine.Benchmark;

public static class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<JsonEngineBenchmarks>();
    }
}
