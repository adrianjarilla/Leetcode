namespace Leetcode
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {

            var uniqueHashSet = new HashSet<int>();

            foreach (var number in nums)
            {
                if (uniqueHashSet.Contains(number))
                {
                    return true;
                }

                uniqueHashSet.Add(number);
            }
            return false;

        }
    }
}