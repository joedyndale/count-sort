```

BenchmarkDotNet v0.13.6, macOS Ventura 13.4.1 (c) (22F770820d) [Darwin 22.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 7.0.307
  [Host]     : .NET 7.0.10 (7.0.1023.36312), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), Arm64 RyuJIT AdvSIMD


```
|                  Method | arraySize |               Mean |             Error |            StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |---------- |-------------------:|------------------:|------------------:|------:|--------:|----------:|------------:|
|    **sortByteArray_Native** |        **10** |           **9.915 ns** |         **0.0399 ns** |         **0.0354 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortByteArray_CountSort |        10 |         215.117 ns |         0.4581 ns |         0.3577 ns | 21.70 |    0.08 |         - |          NA |
|                         |           |                    |                   |                   |       |         |           |             |
|    **sortByteArray_Native** |       **100** |         **237.080 ns** |         **1.4653 ns** |         **1.3707 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortByteArray_CountSort |       100 |         290.952 ns |         2.1665 ns |         1.9206 ns |  1.23 |    0.01 |         - |          NA |
|                         |           |                    |                   |                   |       |         |           |             |
|    **sortByteArray_Native** |       **500** |       **1,805.028 ns** |        **10.4902 ns** |         **9.8126 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortByteArray_CountSort |       500 |         829.980 ns |         1.6858 ns |         1.5769 ns |  0.46 |    0.00 |         - |          NA |
|                         |           |                    |                   |                   |       |         |           |             |
|    **sortByteArray_Native** |      **1000** |       **4,259.056 ns** |        **36.8114 ns** |        **32.6323 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| sortByteArray_CountSort |      1000 |       2,052.587 ns |         6.7331 ns |         5.9687 ns |  0.48 |    0.00 |         - |          NA |
|                         |           |                    |                   |                   |       |         |           |             |
|    **sortByteArray_Native** |   **1000000** |   **6,543,952.098 ns** |    **17,714.2224 ns** |    **14,792.1780 ns** |  **1.00** |    **0.00** |       **7 B** |        **1.00** |
| sortByteArray_CountSort |   1000000 |   2,413,555.396 ns |     7,202.8941 ns |     6,385.1780 ns |  0.37 |    0.00 |       4 B |        0.57 |
|                         |           |                    |                   |                   |       |         |           |             |
|    **sortByteArray_Native** | **100000000** | **897,061,118.538 ns** | **1,613,294.7115 ns** | **1,347,174.1506 ns** |  **1.00** |    **0.00** |     **936 B** |        **1.00** |
| sortByteArray_CountSort | 100000000 | 243,764,003.733 ns |   897,543.7536 ns |   839,562.9840 ns |  0.27 |    0.00 |     312 B |        0.33 |
