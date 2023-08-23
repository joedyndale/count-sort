using BenchmarkDotNet.Attributes;

namespace CountSort.Benchmarks;

[MemoryDiagnoser]
public class ByteBenchmarks
{
    [Params(10, 100, 500, 1_000, 1_000_000, 100_000_000)]
    public int arraySize;

    public byte[]? arrayToSort;

    [GlobalSetup]
    public void GlobalSetup()
    {
        arrayToSort = new byte[arraySize];

        var r = new Random(12345);
        r.NextBytes(arrayToSort);
    }

    [Benchmark(Baseline = true)]
    public void sortByteArray_Native()
    {
        Array.Sort(arrayToSort!);
    }

    [Benchmark]
    public void sortByteArray_CountSort()
    {
        CountSort.SortBytes(arrayToSort!);
    }
}