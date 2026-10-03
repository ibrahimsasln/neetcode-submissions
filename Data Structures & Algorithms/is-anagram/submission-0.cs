public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length) return false;

        var orderedS = s.ToLower().OrderBy(c => c);
        var orderedT = t.ToLower().OrderBy(c => c);

        return orderedS.SequenceEqual(orderedT);
    }
}
