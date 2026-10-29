public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) //[2,2,4,5,6] target = 7
      {
        int rightPoint = numbers.Length - 1;
        int leftPoint = 0;

        while (leftPoint < rightPoint)
        {
            int sum = numbers[leftPoint] + numbers[rightPoint];

            if (sum == target) return new int[] {leftPoint + 1, rightPoint + 1};
            else if(sum < target) leftPoint++;
            else rightPoint--;
        }
        return new int[]{};
    }
}
