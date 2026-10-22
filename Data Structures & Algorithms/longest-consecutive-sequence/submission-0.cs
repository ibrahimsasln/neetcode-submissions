public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new(nums);
        int maxLength = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int newLength = 1;

                while (set.Contains(num + newLength))
                {
                    newLength++;
                }

                maxLength = Math.Max(maxLength, newLength);
            }
        }
        return maxLength;
    }
}
