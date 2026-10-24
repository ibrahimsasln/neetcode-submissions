public class Solution
{
    public bool IsPalindrome(string s)
    {
        StringBuilder builder = new();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c)) builder.Append(char.ToLower(c));
        }

        string newString = builder.ToString();
        return newString == new string(newString.Reverse().ToArray());
    }
}
