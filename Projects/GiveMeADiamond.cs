using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class GiveMeADiamond
    {

        [Fact]
        public void TestDiamond3()
        {
            var expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            Assert.Equal(expected.ToString(), Diamond(3));
        }

        [Fact]
        public void TestDiamond5()
        {
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.Equal(expected.ToString(), Diamond(5));
        }

        public static string Diamond(int n)
        {
            if (n%2 == 0 || n ==0)
            {
                return null;
            }
            var diamond = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var numberOfSpaces = Math.Abs((n - 1) / 2 - i);
                var numberOfAsterisks = n - 2 * numberOfSpaces;

                diamond.Append(' ', numberOfSpaces);
                diamond.Append('*', numberOfAsterisks);
                diamond.Append("\n");
            }

            return diamond.ToString();
        }
    }
}
