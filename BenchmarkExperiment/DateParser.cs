using System;

namespace BenchmarkExperiment
{
    public class DateParser
    {
        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);

            return dateTime.Year;
        }

        public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var hyphenIndex = dateTimeAsSpan.IndexOf('-');

            return int.Parse(dateTimeAsSpan.Slice(0, hyphenIndex));
        }

        public int GetYearFromSpanExplictIntConversion(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var hyphenIndex = dateTimeAsSpan.IndexOf('-');

            var yearAsSpan = dateTimeAsSpan.Slice(0, hyphenIndex);

            return ConvertSpanToInt(yearAsSpan);
        }

        private static int ConvertSpanToInt(ReadOnlySpan<char> yearAsSpan)
        {
            var intReturn = 0;

            for (int i = 0; i < yearAsSpan.Length; i++)
            {
                intReturn *= 10 + (yearAsSpan[i] - '0');
            }

            return intReturn;
        }
    }
}
