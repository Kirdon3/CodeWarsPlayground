using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class WorldBitsWar
    {

        [Fact]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");

            Assert.Equal("odds win", BitsWar(new List<int> { 1, 5, 12 }));
            Assert.Equal("evens win", BitsWar(new List<int> { 7, -3, 20 }));
            Assert.Equal("tie", BitsWar(new List<int> { 7, -3, -2, 6 }));
            Assert.Equal("evens win", BitsWar(new List<int> { -3, -5 }));
            Assert.Equal("tie", BitsWar(new List<int>()));

        }

        public static string BitsWar(List<int> numbers)
        {
            var odds = numbers.Where(x => (x % 2 == 1 && x > 0) || (x % 2 == 0 && x < 0)).Select(x => Math.Abs(x));
            var evens = numbers.Where(x => (x % 2 == 0 && x > 0) || (x % 2 == -1 && x < 0) ).Select(x => Math.Abs(x));

            var powerOfOdds = odds.SelectMany(x => Convert.ToString(x, 2)).Count(x => x == '1');
            var powerOfEvens = evens.SelectMany(x => Convert.ToString(x, 2)).Count(x => x == '1');
            if (powerOfEvens > powerOfOdds)
            {
                return "evens win";
            } else if (powerOfOdds > powerOfEvens)
            {
                return "odds win";
            }
            else
            {
                return "tie";
            }
        }
    }
}
