public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];

        int prefix = 1;
        int suffix = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = prefix;
            prefix *= nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            output[i] *= suffix;
            suffix *= nums[i];
        }

        return output;

        /* Brute force O(n^2)
        
        int[] output = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int product = 1;

            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i) product *= nums[j];
            }

            output[i] = product;
        }
        return output; */
    }
}