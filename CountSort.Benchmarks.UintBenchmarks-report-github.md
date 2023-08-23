```

BenchmarkDotNet v0.13.6, macOS Ventura 13.4.1 (c) (22F770820d) [Darwin 22.5.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 7.0.307
  [Host]     : .NET 7.0.10 (7.0.1023.36312), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), Arm64 RyuJIT AdvSIMD


```
|                              Method |   Categories | arraySize |               Mean |             Error |            StdDev |     Ratio | RatioSD |   Gen0 |   Gen1 |   Gen2 | Allocated | Alloc Ratio |
|------------------------------------ |------------- |---------- |-------------------:|------------------:|------------------:|----------:|--------:|-------:|-------:|-------:|----------:|------------:|
|      **sortUintArray_byteRange_Native** |   **byte range** |        **10** |           **9.917 ns** |         **0.0273 ns** |         **0.0256 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
|   sortUintArray_byteRange_CountSort |   byte range |        10 |         223.807 ns |         0.3694 ns |         0.3456 ns |     22.57 |    0.06 |      - |      - |      - |         - |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_byteRange_Native** |   **byte range** |      **1000** |       **4,250.951 ns** |        **25.7162 ns** |        **22.7967 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
|   sortUintArray_byteRange_CountSort |   byte range |      1000 |       3,050.847 ns |         6.1597 ns |         5.4605 ns |      0.72 |    0.00 |      - |      - |      - |         - |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_byteRange_Native** |   **byte range** |     **10000** |      **53,847.995 ns** |       **504.8874 ns** |       **472.2720 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
|   sortUintArray_byteRange_CountSort |   byte range |     10000 |      35,189.998 ns |       121.7834 ns |       107.9578 ns |      0.65 |    0.01 |      - |      - |      - |         - |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_byteRange_Native** |   **byte range** |    **100000** |     **620,111.469 ns** |     **1,978.0999 ns** |     **1,850.3158 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |       **1 B** |        **1.00** |
|   sortUintArray_byteRange_CountSort |   byte range |    100000 |     330,387.470 ns |     3,283.4965 ns |     3,071.3847 ns |      0.53 |    0.00 |      - |      - |      - |         - |        0.00 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_byteRange_Native** |   **byte range** |   **1000000** |   **6,597,147.065 ns** |    **15,698.3470 ns** |    **13,916.1757 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |       **7 B** |        **1.00** |
|   sortUintArray_byteRange_CountSort |   byte range |   1000000 |   3,255,784.881 ns |     5,569.0047 ns |     5,209.2504 ns |      0.49 |    0.00 |      - |      - |      - |       4 B |        0.57 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_byteRange_Native** |   **byte range** | **100000000** | **900,696,680.400 ns** | **1,140,953.8514 ns** | **1,067,248.9405 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |     **936 B** |        **1.00** |
|   sortUintArray_byteRange_CountSort |   byte range | 100000000 | 327,914,546.179 ns | 1,039,195.0310 ns |   921,219.3271 ns |      0.36 |    0.00 |      - |      - |      - |     468 B |        0.50 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_fullRange_Native** |   **full range** |        **10** |           **9.899 ns** |         **0.0174 ns** |         **0.0145 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
|   sortUintArray_fullRange_CountSort |   full range |        10 |          16.527 ns |         0.0459 ns |         0.0430 ns |      1.67 |    0.01 |      - |      - |      - |         - |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_fullRange_Native** |   **full range** |      **1000** |       **2,999.591 ns** |        **14.3675 ns** |        **12.7365 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
|   sortUintArray_fullRange_CountSort |   full range |      1000 |       3,548.573 ns |         9.2307 ns |         8.1827 ns |      1.18 |    0.01 |      - |      - |      - |         - |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_fullRange_Native** |   **full range** |     **10000** |      **44,511.960 ns** |       **124.3204 ns** |       **110.2068 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
|   sortUintArray_fullRange_CountSort |   full range |     10000 |      50,042.790 ns |        99.7078 ns |        83.2605 ns |      1.12 |    0.00 |      - |      - |      - |         - |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_fullRange_Native** |   **full range** |    **100000** |     **514,897.874 ns** |       **798.7551 ns** |       **708.0756 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |       **1 B** |        **1.00** |
|   sortUintArray_fullRange_CountSort |   full range |    100000 |     574,318.506 ns |     2,683.0059 ns |     2,509.6854 ns |      1.12 |    0.01 |      - |      - |      - |       1 B |        1.00 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_fullRange_Native** |   **full range** |   **1000000** |   **5,916,919.354 ns** |    **30,901.3574 ns** |    **24,125.7472 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |       **7 B** |        **1.00** |
|   sortUintArray_fullRange_CountSort |   full range |   1000000 |   6,489,479.383 ns |    47,418.7630 ns |    44,355.5403 ns |      1.10 |    0.01 |      - |      - |      - |       7 B |        1.00 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|      **sortUintArray_fullRange_Native** |   **full range** | **100000000** | **816,066,848.143 ns** | **2,364,612.1813 ns** | **2,096,167.1078 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |     **936 B** |        **1.00** |
|   sortUintArray_fullRange_CountSort |   full range | 100000000 | 888,305,357.214 ns | 3,912,564.7476 ns | 3,468,386.7384 ns |      1.09 |    0.01 |      - |      - |      - |     936 B |        1.00 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|    **sortUintArray_ushortRange_Native** | **ushort range** |        **10** |          **10.048 ns** |         **0.1102 ns** |         **0.1031 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
| sortUintArray_ushortRange_CountSort | ushort range |        10 |     119,978.141 ns |       445.1775 ns |       371.7434 ns | 11,953.73 |  133.30 | 0.2441 | 0.2441 | 0.2441 |     232 B |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|    **sortUintArray_ushortRange_Native** | **ushort range** |      **1000** |       **3,056.555 ns** |         **9.2992 ns** |         **8.2435 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
| sortUintArray_ushortRange_CountSort | ushort range |      1000 |     128,057.733 ns |       700.5036 ns |       620.9782 ns |     41.90 |    0.19 | 0.2441 | 0.2441 | 0.2441 |     232 B |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|    **sortUintArray_ushortRange_Native** | **ushort range** |     **10000** |      **49,417.043 ns** |       **207.1203 ns** |       **183.6068 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
| sortUintArray_ushortRange_CountSort | ushort range |     10000 |     197,250.222 ns |     2,413.2116 ns |     1,884.0769 ns |      3.99 |    0.04 | 0.2441 | 0.2441 | 0.2441 |     232 B |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|    **sortUintArray_ushortRange_Native** | **ushort range** |    **100000** |     **763,136.524 ns** |     **2,088.8412 ns** |     **1,851.7033 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |         **-** |          **NA** |
| sortUintArray_ushortRange_CountSort | ushort range |    100000 |     890,610.392 ns |     2,764.0426 ns |     2,308.1008 ns |      1.17 |    0.00 |      - |      - |      - |     233 B |          NA |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|    **sortUintArray_ushortRange_Native** | **ushort range** |   **1000000** |   **9,617,750.328 ns** |    **48,013.8981 ns** |    **42,563.0701 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |      **15 B** |        **1.00** |
| sortUintArray_ushortRange_CountSort | ushort range |   1000000 |   4,065,841.192 ns |    13,991.3275 ns |    13,087.4964 ns |      0.42 |    0.00 |      - |      - |      - |     239 B |       15.93 |
|                                     |              |           |                    |                   |                   |           |         |        |        |        |           |             |
|    **sortUintArray_ushortRange_Native** | **ushort range** | **100000000** | **895,784,080.286 ns** | **1,359,119.4573 ns** | **1,204,823.9980 ns** |      **1.00** |    **0.00** |      **-** |      **-** |      **-** |     **936 B** |        **1.00** |
| sortUintArray_ushortRange_CountSort | ushort range | 100000000 | 334,036,008.333 ns | 1,030,369.0850 ns |   963,807.8814 ns |      0.37 |    0.00 |      - |      - |      - |     700 B |        0.75 |
