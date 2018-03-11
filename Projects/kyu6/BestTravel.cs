using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace kyu5
{
    public class BestTravel
    {
        //TODO: FINISH THIS.

        [Fact]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = chooseBestSum(163, 3, ts);
            Assert.Equal(163, n);

            ts = new List<int> { 50 };
            n = chooseBestSum(163, 3, ts);
            Assert.Null(n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = chooseBestSum(230, 3, ts);
            Assert.Equal(228, n);
        }

        public static IEnumerable<IEnumerable<int>> Combinations(IEnumerable<int> elements, int k)
        {
            var elementsList = elements.ToList();
            if (k == 0)
            {
                return new [] {new int[0]};
            }
            else
            {
                var redasd = elementsList.SelectMany((e, i) =>
                {
                    var testCol = Combinations(elementsList.Skip(i + 1), k - 1).ToList();
                    var result = testCol.Select(c => (new[] { e }).Concat(c));
                    return result;
                });
                return redasd;
            }
        }

        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            var listOfCombs = Combinations(ls, k).ToList();
            if (!listOfCombs.Any())
            {
                return null;
            }
            var sums =  listOfCombs.Select(x => x.Sum()).Where(x => x <= t).ToList();
            if (sums.Any())
            {
                return sums.Max();
            }
            else
            {
                return null;
            }

        }

        [Fact]
        public void Test()
        {
            Console.WriteLine("****** Basic Tests");
            List<int> ts = new List<int> { 50, 55, 57, 58, 60 };
            int? n = chooseBestSum(174, 3, ts);
            Assert.Equal(173, n);
        }

        [Fact]
        public void CalculateAllThreeCombinationsTest()
        {
            Console.WriteLine("****** Basic Tests");
            List<int> ts = new List<int> { 50, 55, 57, 58, 60 };
            List<List<int>> expected = new List<List<int>>
            {
                new List<int> {50, 55, 57},
                new List<int> {50, 55, 58},
                new List<int> {50, 55, 60},
                new List<int> {50, 57, 58},
                new List<int> {50, 57, 60},
                new List<int> {50, 58, 60},
                new List<int> {55, 57, 58},
                new List<int> {55, 57, 60},
                new List<int> {55, 58, 60},
                new List<int> {57, 58, 60},
            };
            var result = Combinations(ts, 3).ToList();
            Assert.Equal(expected, result);
        }


        [Fact]
        public void CalculateAllTwoElementVariationsTest()
        {
            Console.WriteLine("****** Basic Tests");
            List<int> ts = new List<int> { 50, 55, 57, 58, 60 };
            List<List<int>> expected = new List<List<int>>
            {
                new List<int> {50, 55},
                new List<int> {50, 57},
                new List<int> {50, 58},
                new List<int> {50, 60},
                new List<int> {55, 57},
                new List<int> {55, 58},
                new List<int> {55, 60},
                new List<int> {57, 58},
                new List<int> {57, 60},
                new List<int> {58, 60}
            };
            Assert.Equal(expected, calculateTwoElementsVariations(ts, 0));
        }

        public static List<List<int>> calculateTwoElementsVariations(List<int> ls, int startPosition)
        {
            var result = new List<List<int>>();
            var arr = ls.ToArray();
            var initialItem = arr[startPosition];
            for (int i = startPosition+1; i < ls.Count; i++)
            {
                var item = arr[i];
                result.Add(new List<int>
                {
                    initialItem, item
                });
            }

            if (startPosition < ls.Count-2)
            {
                result = result.Concat(calculateTwoElementsVariations(ls, startPosition+1)).ToList();
            }

            return result;
        }







    }
}


