using BenchmarkDotNet.Attributes;

namespace CountSort.Benchmarks;

[MemoryDiagnoser]
public class SbyteBenchmarks
{
    [Params(10, 100, 500, 1_000, 1_000_000, 100_000_000)]
    public int arraySize;

    public sbyte[]? arrayToSort;

    [GlobalSetup]
    public void GlobalSetup()
    {
        arrayToSort = new sbyte[arraySize];

        var r = new Random();

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = (sbyte)r.Next(-128, 128);
        }
    }

    [Benchmark(Baseline = true)]
    public void sortSbyteArray_Native()
    {
        Array.Sort(arrayToSort!);
    }

    [Benchmark]
    public void sortSbyteArray_CountSort()
    {
        CountSort.SortSbytes(arrayToSort!);
    }
}