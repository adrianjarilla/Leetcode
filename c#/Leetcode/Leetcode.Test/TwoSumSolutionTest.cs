namespace Leetcode.Test
{
    [TestFixture]
    public class TwoSumSolutionTest
    {
        private TwoSumSolution _twoSumSolution;

        [SetUp]
        public void Setup()
        {
            _twoSumSolution = new TwoSumSolution();
        }

        [Test]
        public void TwoSum_AscendingOrder_ReturnIndices()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var target = 3;

            var result = _twoSumSolution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(1));

        }

        [Test]
        public void TwoSum_UnOrdered_ReturnIndices()
        {
            var nums = new int[] { 5, 50, 75, 45 };
            var target = 50;

            var result = _twoSumSolution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(3));
        }

        [Test] public void TwoSum_Duplicates_ReturnIndices()
        {
            var nums = new int[] { 1, 1, 4, 1,5 };
            var target = 6;

            var result = _twoSumSolution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(3));
            Assert.That(result[1], Is.EqualTo(4));
        }
    }
}
