using NUnit.Framework;

namespace WeekExercises
{
    public class MinMax
    {
        public static string MiniMaxSum(List<int> arr)
        {
            var orderedList = arr.OrderBy(e => e).Take(4).ToArray();
            var orderedListDesc = arr.OrderByDescending(e => e).Take(4).ToArray();

            long minVal = default;
            long maxVal = default;

            for (int i = 0; i < orderedList.Length; i++)
                minVal += orderedList[i];

            for (int i = 0; i < orderedListDesc.Length; i++)
                maxVal += orderedListDesc[i];

            return $"{minVal} {maxVal}";
        }

    }

    [TestFixture]
    public class MinMaxRunner
    {
        [SetUp]
        public void SetUp()
        {
        }

        private static IEnumerable<TestCaseData> RunScenarios
        {
            get 
            {
                yield return new TestCaseData(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 }, "2063136757 2744467344");
            }
        }

        [TestCaseSource(nameof(RunScenarios))]
        public void Run(List<int> arr, string expectedOutput)
        {
            var result = MinMax.MiniMaxSum(arr);

            Assert.AreEqual(expectedOutput, result);
        }
    }
}
