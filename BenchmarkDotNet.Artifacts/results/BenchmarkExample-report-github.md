``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i5-4210M CPU 2.60GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|              Method |        Mean |     Error |    StdDev |      Median |
|-------------------- |------------:|----------:|----------:|------------:|
|             MathPow |   0.2370 ns | 0.1533 ns | 0.3554 ns |   0.0000 ns |
| StringConcatenation |  89.3382 ns | 1.1426 ns | 1.0688 ns |  88.7992 ns |
|       StringBuilder | 176.3739 ns | 2.0074 ns | 1.7795 ns | 177.1417 ns |
