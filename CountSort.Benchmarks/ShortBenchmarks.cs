using BenchmarkDotNet.Attributes;

namespace CountSort.Benchmarks;

[MemoryDiagnoser]
public class ShortBenchmarks
{
    [Params(10, 1_000, 10_000, 100_000, 1_000_000, 100_000_000)]
    public int arraySize;

    public short[]? arrayToSort;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var r = new Random();

        arrayToSort = new short[arraySize];
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (short)r.Next(-32_768, 32_767);
        }
    }

    [Benchmark(Baseline = true)]
    public void sortShortArray_Native()
    {
        Array.Sort(arrayToSort!);
    }

    [Benchmark]
    public void sortShortArray_CountSort()
    {
        CountSort.SortShorts(arrayToSort!);
    }
}