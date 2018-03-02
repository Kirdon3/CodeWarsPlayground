using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class RoundToHalf
    {

        [Fact]
        public void SampleTest1()
        {
            Assert.Equal(4, Round(4.2));
            Assert.Equal(4.5, Round(4.4));
            Assert.Equal(4.5, Round(4.6));
            Assert.Equal(5, Round(4.8));
        }

        public static double Round(double n)
        {
            var mainPart = (decimal)Math.Floor(n);
            var theEnding = (decimal)n - mainPart;

            if (theEnding >= 0.75M)
            {
                return Convert.ToDouble(mainPart + 1);
            }
            else if (theEnding >= 0.25M)
            {
                return Convert.ToDouble(mainPart + 0.5M);
            }
            else
            {
                return Convert.ToDouble(mainPart);
            }
        }
    }
}
