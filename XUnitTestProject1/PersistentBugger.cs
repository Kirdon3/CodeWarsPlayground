using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class PersistentBugger
    {
        [Fact]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");

            Assert.Equal(3, Persistence(39));
            Assert.Equal(0, Persistence(4));
            Assert.Equal(2, Persistence(25));
            Assert.Equal(4, Persistence(999));

        }

        public static int Persistence(long n)
        {
            int result = 0;
            var numberAsString = n.ToString();
            var digits = numberAsString.Select(x => long.Parse(x.ToString())).ToList();

            while (HasNextPersistence(digits, out digits))
            {
                result++;
            }

            return result;
        }

        private static  bool HasNextPersistence(List<long> digits, out List<long> nextIteration)
        {
            if (digits.Count() <= 1)
            {
                nextIteration = digits;
                return false;
            }
            else
            {
                long nextIterationNumber = 1;

                foreach (var digit in digits)
                {
                    nextIterationNumber *= digit;
                }
                nextIteration = nextIterationNumber.ToString().Select(x => (long)char.GetNumericValue(x)).ToList();
                return true;
            }

        }
    }
}
