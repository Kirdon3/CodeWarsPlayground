using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class DataReverse
    {

        [Fact]
        
        public static void test1()
        {
            int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
            int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
            Assert.Equal(data2, dataReverse(data1));
        }

        [Fact]
        public static void test2()
        {
            int[] data1 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
            int[] data2 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
            Assert.Equal(data2, dataReverse(data1));
        }

        public static int[] dataReverse(int[] data)
        {
            var result = new List<int>();
            for (int i = data.Length; i > 0; i = i - 8)
            {
                result = result.Concat(data.Skip(i - 8).Take(8)).ToList();
            }
            return result.ToArray();
        }
    }
}
