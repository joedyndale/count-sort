```

BenchmarkDotNet v0.13.6, macOS Ventura 13.4.1 (c) (22F770820d) [Darwin 22.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 7.0.307
  [Host]     : .NET 7.0.10 (7.0.1023.36312), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), Arm64 RyuJIT AdvSIMD


```
|                   Method | arraySize |               Mean |             Error |            StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------- |---------- |-------------------:|------------------:|------------------:|------:|--------:|----------:|------------:|
|    **sortSbyteArray_Native** |        **10** |           **9.923 ns** |         **0.0308 ns** |         **0.0273 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortSbyteArray_CountSort |        10 |         215.931 ns |         0.6499 ns |         0.5761 ns | 21.76 |    0.08 |         - |          NA |
|                          |           |                    |                   |                   |       |         |           |             |
|    **sortSbyteArray_Native** |       **100** |         **186.075 ns** |         **0.8912 ns** |         **0.7900 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortSbyteArray_CountSort |       100 |         337.808 ns |         0.6594 ns |         0.6168 ns |  1.82 |    0.01 |         - |          NA |
|                          |           |                    |                   |                   |       |         |           |             |
|    **sortSbyteArray_Native** |       **500** |       **1,806.610 ns** |        **19.7436 ns** |        **18.4682 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortSbyteArray_CountSort |       500 |         990.761 ns |         3.7634 ns |         3.5203 ns |  0.55 |    0.01 |         - |          NA |
|                          |           |                    |                   |                   |       |         |           |             |
|    **sortSbyteArray_Native** |      **1000** |       **4,426.633 ns** |        **45.1887 ns** |        **42.2696 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortSbyteArray_CountSort |      1000 |       2,163.747 ns |         7.0006 ns |         6.5483 ns |  0.49 |    0.01 |         - |          NA |
|                          |           |                    |                   |                   |       |         |           |             |
|    **sortSbyteArray_Native** |   **1000000** |   **6,577,454.682 ns** |    **10,575.9588 ns** |     **9,375.3120 ns** |  **1.00** |    **0.00** |       **7 B** |        **1.00** |
| sortSbyteArray_CountSort |   1000000 |   2,369,452.965 ns |     6,655.4936 ns |     6,225.5528 ns |  0.36 |    0.00 |       4 B |        0.57 |
|                          |           |                    |                   |                   |       |         |           |             |
|    **sortSbyteArray_Native** | **100000000** | **896,208,208.286 ns** | **2,216,347.0100 ns** | **1,964,733.8953 ns** |  **1.00** |    **0.00** |     **936 B** |        **1.00** |
| sortSbyteArray_CountSort | 100000000 | 239,624,793.489 ns |   424,311.7857 ns |   396,901.5076 ns |  0.27 |    0.00 |     312 B |        0.33 |
