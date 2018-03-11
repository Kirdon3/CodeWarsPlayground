using System;
using System.Text;
using Xunit;

namespace FirstBatch.kyu6
{
    public class BuildTower
    {

        [Fact]
        public void SampleTest1()
        {
            Assert.Equal(string.Join(",", new[] { "*" }), string.Join(",", TowerBuilder(1)));
            Assert.Equal(string.Join(",", new[] { " * ", "***" }), string.Join(",", TowerBuilder(2)));
            Assert.Equal(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", TowerBuilder(3)));
        }

        public static string[] TowerBuilder(int nFloors)
        {
            var result = new string[nFloors];
            var baseLength = ( 2 * nFloors ) - 1;

            for (int i = 0; i < nFloors; i++)
            {
                var sb = new StringBuilder();
                sb.Append(' ', (( baseLength - ((2 * i) + 1))) / 2);
                sb.Append('*', (2 * i) + 1);
                sb.Append(' ', ((baseLength - ((2 * i) + 1))) / 2);
                result[i] = sb.ToString();
            }

            return result;
        }
    }
}
