using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace kyu6
{
    public class CommonDenominators
    {
        [Fact]
        public void Test1()
        {
            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            Assert.Equal("(6,12)(4,12)(3,12)", convertFrac1(lst));
        }

        public static string convertFrac(long[,] lst)
        {
            if (lst.Length == 0)
            {
                return String.Empty;
            }
            var listOfPairs = new List<long[]>();

            for (int i = 0; i <= lst.GetUpperBound(0); i++)
            {
                listOfPairs.Add(new[] {lst[i, 1], lst[i, 1]});
            }
            while (listOfPairs.Any(x => x[1] != listOfPairs.First()[1]))
            {
                var minValue = listOfPairs.Min(x => x[1]);
                var key = listOfPairs.FirstOrDefault(x => x[1] == minValue);
                key[1] = key[0] + minValue;
            }

            var commonDenominator = listOfPairs.First()[1];
            var numbers = listOfPairs.Select(x => x[1] / x[0]).ToArray();

            var sb = new StringBuilder();
            for (int i = 0; i <= lst.GetUpperBound(0); i++)
            {
                sb.Append($"({numbers[i] * lst[i, 0]},{commonDenominator})");
            }
            return sb.ToString();
        }

        public static string convertFrac1(long[,] lst)
        {
            int c = lst.GetLength(0);
            long l = 1;
            for (var i = 0; i < c; i++) l = LCM(lst[i, 1], l);
            var sb = new StringBuilder();
            for (var i = 0; i < c; i++)
            {
                sb.AppendFormat("({0},{1})", lst[i, 0] * l / lst[i, 1], l);
            }
            return sb.ToString();
        }

        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static long LCM(long a, long b)
        {
            return a * b / GCD(a, b);
        }
    }
}
