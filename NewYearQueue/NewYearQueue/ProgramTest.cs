using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearQueue
{
    [TestFixture]
    public class ProgramTest
    {
        private static IEnumerable<TestCaseData> _scenarios 
        {
            get 
            {
                yield return new TestCaseData(new[] { 1, 2, 3, 5, 4, 6, 7, 8 }, "1");
                yield return new TestCaseData(new[] { 4, 1, 2, 3 }, "Too Chaotic");
            }
        }

        [TestCaseSource(nameof(_scenarios))]
        public void MainSolutionTest(int[] inputArray, string expectedResult)
        {
            var prog = new Program();
            var result = prog.Solution(inputArray);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
