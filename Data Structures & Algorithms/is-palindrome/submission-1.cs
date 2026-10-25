public class Solution
{
    public bool IsPalindrome(string s)
    {
        int leftP = 0;
        int rightP = s.Length - 1;

        while (leftP < rightP)
        {
            while (leftP < rightP && !char.IsLetterOrDigit(s[leftP]))
            {
                leftP++;
            }
            while (leftP < rightP && !char.IsLetterOrDigit(s[rightP]))
            {
                rightP--;
            }

            if (char.ToLower(s[leftP]) != char.ToLower(s[rightP])) return false;
            
            rightP--;
            leftP++;
        }
        return true;
    }
}
