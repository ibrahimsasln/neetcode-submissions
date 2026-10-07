public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(target - nums[i]))
            {
                return new int[] {dictionary[target - nums[i]], i};
            }

            dictionary[nums[i]] = i;
        }
        return new int[0];

       /* brute force:
       
       for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target) return new int[] {i,j};
            }
        }
        return new int[0]; */
    }
}
