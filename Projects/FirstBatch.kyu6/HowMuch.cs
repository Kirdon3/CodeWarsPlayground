using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class HowMuch
    {

        [Fact]
        public static void BasicTest()
        {
            ////Assert.Equal("[[M: 37 B: 5 C: 4][M: 100 B: 14 C: 11]]", howmuch(1, 100));
            ////Assert.Equal("[]", howmuch(2950, 2950));
            ////Assert.Equal("[]", howmuch(0, 200));
            ////Assert.Equal("[]", howmuch(1000, 1100));
            Assert.Equal("[[M: 9991 B: 1427 C: 1110]]", howmuch(10000, 9950));
        }

        public static string howmuch(int m, int n)
        {
            var builder = new StringBuilder();
            builder.Append('[');
            if (m > n)
            {
                var temp = m;
                m = n;
                n = temp;
            }
            for (decimal i = m; i <= n; i++)
            {
                var car = (i - 1) / 9;
                var boat = (i - 2) / 7;

                if ((int)car == 0 || (int)boat == 0 )
                {
                    continue;
                }

                if (car%(int)car == 0 && boat%(int)boat == 0)
                {
                    builder.Append($"[M: {i} B: {boat} C: {car}]");
                }
            }
            return builder.Append(']').ToString();
        }
    }
}
