``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i5-4210M CPU 2.60GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|   Method |     Mean |    Error |   StdDev |   Median |
|--------- |---------:|---------:|---------:|---------:|
| MyMethod | 13.11 ms | 0.541 ms | 1.579 ms | 12.32 ms |
