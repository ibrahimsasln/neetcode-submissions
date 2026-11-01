public class Solution
{
    public int MaxArea(int[] heights)
    {
        /* -------------------------------------------------
        BRUTE FORCE

        int maxArea = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i + 1; j < heights.Length; j++)
            {
                int area = Math.Min(heights[i], heights[j]) * (j - i);
                maxArea = Math.Max(maxArea, area);
            }
        }
        return maxArea; 
        ----------------------------------------------------*/

        int leftP = 0;
        int rightP = heights.Length - 1;
        
        int maxArea = 0;

        while(leftP < rightP)
        {
           int area = Math.Min(heights[leftP], heights[rightP]) * (rightP - leftP);
           if (heights[leftP] < heights[rightP]) leftP++;
           else rightP--;

           maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}
