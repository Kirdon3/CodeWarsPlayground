using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class IntegerDepth
    {

        [Fact]
        public void SampleTest1()
        {
            Assert.Equal(10, ComputeDepth(1));
        }

        [Fact]
        public void SampleTest2()
        {
            Assert.Equal(9, ComputeDepth(42));
        }

        [Fact]
        public void SampleTest3()
        {
            Assert.Equal(1, ComputeDepth(1234567890));
            Assert.Equal(3, ComputeDepth(8779920));
        }

        public static int ComputeDepth(int n)
        {
            var allDigits = new HashSet<char>();
            var depth = 0;
            do
            {
                depth++;
                var n1 = depth * n;
                foreach (var c in n1.ToString())
                {
                    allDigits.Add(c);
                }

                
            } while (allDigits.Count < 10);
            
            return depth;
        }
    }
}
