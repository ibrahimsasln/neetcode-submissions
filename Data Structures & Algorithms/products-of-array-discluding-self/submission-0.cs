public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        int[] output = new int[nums.Length];

        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        for (int i = 1; i < nums.Length; i++)
        {
            suffix[nums.Length - i - 1] = suffix[nums.Length - i] * nums[nums.Length - i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = prefix[i] * suffix[i];
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