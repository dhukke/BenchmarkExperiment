# BenchmarkExperiment

First time playing around with Span object and benchmarking it to check the power of Span.

Inspiration came from: https://youtu.be/EWmufbVF2A4.

Results:

|                              Method |      Mean |    Error |   StdDev | Ratio | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |----------:|---------:|---------:|------:|-----:|------:|------:|------:|----------:|
| GetYearFromSpanExplictIntConversion |  14.03 ns | 0.143 ns | 0.126 ns |  0.02 |    1 |     - |     - |     - |         - |
|                     GetYearFromSpan |  30.94 ns | 0.627 ns | 0.697 ns |  0.05 |    2 |     - |     - |     - |         - |
|                 GetYearFromDateTime | 672.69 ns | 8.305 ns | 7.362 ns |  1.00 |    3 |     - |     - |     - |         - |
