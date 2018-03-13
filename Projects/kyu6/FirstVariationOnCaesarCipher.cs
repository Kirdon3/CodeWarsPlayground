using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace kyu5
{
    public class FirstVariationOnCaesarCipher
    {
        [Fact]
        public void Test1()
        {
            string u = "I should have known that you would have a perfect answer for me!!!";
            Assert.Equal(u, demovingShift(movingShift(u, 1), 1));
        }
        
        [Fact]
        [InlineData("1111111111111111", 4, 4, 4, 4 , 1)]
        [InlineData("11111111111111111", 4, 4, 4, 4 , 0)]
        [InlineData("11111111111", 3, 3, 3, 2 , 0)]
        public void Test2(string input, int first, int second, int third, int fourth, int fifth)
        {
            var result = splitString(input);
            Assert.Equal(result[0].Length, first);
            Assert.Equal(result[1].Length, second);
            Assert.Equal(result[2].Length, third);
            Assert.Equal(result[3].Length, fourth);
            Assert.Equal(result[4].Length, fifth);
        }

        public static List<string> movingShift(string s, int shift)
        {
            var strLength = s.Length;
            var myTestNumber = (decimal)strLength / 5;
            var dwa = Math.Ceiling(myTestNumber);
            return new List<string>();
        }

        public static string demovingShift(List<string> s, int shift)
        {
            return "";
        }

        public static string[] splitString(string s)
        {
            var strLength = s.Length;
            var equalLength = (decimal)strLength / 5;
            var biggestPartLength = (int)Math.Ceiling(equalLength);

            var result = new string[5];

            result[0] = s.Substring(0, biggestPartLength);

            for (int i = 0; i < 5; i++)
            {
                result[i] = 
            }
        }
    }
}
