namespace Leetcode
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var previousMap = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var difference = target - num;

                if (previousMap.ContainsKey(difference))
                {
                    return new int[] { previousMap[difference], i };
                }

                previousMap[num] = i;

            }
            return new int[] { };
        }
    }
}
