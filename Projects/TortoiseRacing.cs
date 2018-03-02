using System;
using Xunit;

namespace FirstBatch.kyu6
{
    public class TortoiseRacing
    {

        [Fact]
        public void SampleTest1()
        {
            Assert.Equal(new int[] { 0, 32, 18 }, Race(720, 850, 70));
            Assert.Equal(new int[] { 3, 21, 49 }, Race(80, 91, 37));
            Assert.Equal(new int[] { 2, 0, 0 }, Race(80, 100, 40));

            Assert.Equal(new int[] { 0, 32, 18 }, Race(720, 850, 70));
            Assert.Equal(new int[] { 3, 21, 49 }, Race(80, 91, 37));
            Assert.Equal(new int[] { 2, 0, 0 }, Race(80, 100, 40));
            Assert.Equal(new int[] { 0, 17, 4 }, Race(720, 850, 37));
        }

        public static int[] Race(int v1, int v2, int g)
        {
            if (v2 <= v1)
            {
                return null;
            }
            var timeInHours = (float)g / ((float)v2 - (float)v1); //inHours
            var seconds = (int)(timeInHours * 60 * 60);
            TimeSpan time = new TimeSpan(0, 0, seconds);
            return new[] {time.Hours, time.Minutes, time.Seconds};
        }
    }
}
