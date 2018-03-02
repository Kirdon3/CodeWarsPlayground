using System;
using Xunit;

namespace FirstBatch.kyu6
{
    public class BouncingBalls
    {

        [Fact]
        public void Test1()
        {
            Assert.Equal(3, bouncingBall(3.0, 0.66, 1.5));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(15, bouncingBall(30.0, 0.66, 1.5));
        }

        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <=0 || bounce <=0 || bounce > 1 || window >= h)
            {
                return -1;
            }

            int numberOfPasses = 1;

            while (h * bounce > window)
            {
                h = h * bounce;
                numberOfPasses = numberOfPasses + 2;
            }
            return numberOfPasses;
        }
    }
}
