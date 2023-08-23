using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace CountSort.Benchmarks;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[MemoryDiagnoser]
public class UintBenchmarks
{
    [Params(10, 1_000, 10_000, 100_000, 1_000_000, 100_000_000)]
    public int arraySize;

    public uint[]? arrayToSort_fullRange;
    public uint[]? arrayToSort_ushortRange;
    public uint[]? arrayToSort_byteRange;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var r = new Random();

        arrayToSort_fullRange = new uint[arraySize];
        for (int i = 0; i < arrayToSort_fullRange.Length; i++)
        {
            arrayToSort_fullRange[i] = (uint)r.NextInt64(0, 4_294_967_296);
        }

        arrayToSort_ushortRange = new uint[arraySize];
        for (int i = 0; i < arrayToSort_ushortRange.Length; i++)
        {
            arrayToSort_ushortRange[i] = (uint)r.Next(1_234_567, 1_234_567 + 65_536);
        }

        arrayToSort_byteRange = new uint[arraySize];
        for (int i = 0; i < arrayToSort_byteRange.Length; i++)
        {
            arrayToSort_byteRange[i] = (uint)r.Next(1_234_567, 1_234_567 + 256);
        }
    }

    [BenchmarkCategory("full range"), Benchmark(Baseline = true)]
    public void sortUintArray_fullRange_Native()
    {
        Array.Sort(arrayToSort_fullRange!);
    }

    [BenchmarkCategory("full range"), Benchmark]
    public void sortUintArray_fullRange_CountSort()
    {
        CountSort.SortUints(arrayToSort_fullRange!);
    }

    [BenchmarkCategory("ushort range"), Benchmark(Baseline = true)]
    public void sortUintArray_ushortRange_Native()
    {
        Array.Sort(arrayToSort_ushortRange!);
    }

    [BenchmarkCategory("ushort range"), Benchmark]
    public void sortUintArray_ushortRange_CountSort()
    {
        CountSort.SortUints(arrayToSort_ushortRange!);
    }

    [BenchmarkCategory("byte range"), Benchmark(Baseline = true)]
    public void sortUintArray_byteRange_Native()
    {
        Array.Sort(arrayToSort_byteRange!);
    }

    [BenchmarkCategory("byte range"), Benchmark]
    public void sortUintArray_byteRange_CountSort()
    {
        CountSort.SortUints(arrayToSort_byteRange!);
    }
}