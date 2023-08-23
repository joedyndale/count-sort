using BenchmarkDotNet.Attributes;

namespace CountSort.Benchmarks;

[MemoryDiagnoser]
public class UshortBenchmarks
{
    [Params(10, 1_000, 10_000, 100_000, 1_000_000, 100_000_000)]
    public int arraySize;

    public ushort[]? arrayToSort;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var r = new Random();

        arrayToSort = new ushort[arraySize];
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (ushort)r.Next(0, 65536);
        }
    }

    [Benchmark(Baseline = true)]
    public void sortUshortArray_Native()
    {
        Array.Sort(arrayToSort!);
    }

    [Benchmark]
    public void sortUshortArray_CountSort()
    {
        CountSort.SortUshorts(arrayToSort!);
    }
}