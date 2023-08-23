using BenchmarkDotNet.Running;
using CountSort.Benchmarks;

var summary = BenchmarkRunner.Run<ByteBenchmarks>();
//var summary = BenchmarkRunner.Run<SbyteBenchmarks>();
//var summary = BenchmarkRunner.Run<UshortBenchmarks>();
//var summary = BenchmarkRunner.Run<ShortBenchmarks>();
//var summary = BenchmarkRunner.Run<UintBenchmarks>();