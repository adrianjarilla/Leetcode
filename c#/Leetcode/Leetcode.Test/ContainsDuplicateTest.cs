namespace Leetcode.Test
{
    [TestFixture]
    public class ContainsDuplicateTest
    {
        private ContainsDuplicateSolution _containsDuplicateSolution;
        [SetUp]
        public void Setup()
        {
            _containsDuplicateSolution = new ContainsDuplicateSolution();
        }

        [Test]
        public void ContainsDuplicate_WithDuplicate_ReturnTrue()
        {
            var nums = new int[] { 1, 2, 3, 1 };

            var result = _containsDuplicateSolution.ContainsDuplicate(nums);

            Assert.IsTrue(result);
        }

        [Test]
        public void ContainsDuplicate_WithoutDuplicate_ReturnFalse()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var result = _containsDuplicateSolution.ContainsDuplicate(nums);

            Assert.IsFalse(result);
        }

        [Test]
        public void ContainsDuplicate_WithMultipleDuplicate_ReturnTrue()
        {
            var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            var result = _containsDuplicateSolution.ContainsDuplicate(nums);

            Assert.IsTrue(result);
        }

    }
}