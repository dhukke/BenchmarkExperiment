``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1440 (1909/November2018Update/19H2)
Intel Core i5-6600K CPU 3.50GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  DefaultJob : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT


```
|                              Method |      Mean |    Error |   StdDev | Ratio | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |----------:|---------:|---------:|------:|-----:|------:|------:|------:|----------:|
| GetYearFromSpanExplictIntConversion |  14.03 ns | 0.143 ns | 0.126 ns |  0.02 |    1 |     - |     - |     - |         - |
|                     GetYearFromSpan |  30.94 ns | 0.627 ns | 0.697 ns |  0.05 |    2 |     - |     - |     - |         - |
|                 GetYearFromDateTime | 672.69 ns | 8.305 ns | 7.362 ns |  1.00 |    3 |     - |     - |     - |         - |
