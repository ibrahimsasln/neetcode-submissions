public class Solution
{
    public List<List<int>> ThreeSum(int[] nums) // nums=[-2, 0, 0, 2, 2]
    {
        Array.Sort(nums); // O(n log n)

        List<List<int>> result = new();

        for (int i = 0; i < nums.Length; i++) 
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int leftP = i + 1;
            int rightP = nums.Length - 1;

            while(leftP < rightP)
            {
                int sum = nums[i] + nums[leftP] + nums[rightP];

                if (sum < 0)
                {
                    leftP++;
                    continue;
                }
                else if (sum > 0)
                {
                    rightP--;
                    continue;
                }
                else
                {
                    result.Add(new List<int>{nums[i], nums[leftP], nums[rightP]});
                    leftP++;
                    rightP--;

                     while (leftP < rightP && nums[leftP] == nums[leftP - 1]) //[-2, 0, 0, 2, 2]
                    {
                        leftP++;
                    }
                }
            }
        }
        return result;
    }
}
