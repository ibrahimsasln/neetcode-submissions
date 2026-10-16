public class Solution {

    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new();

        foreach(string st in strs)
        {
            sb.Append(st.Length);
            sb.Append('#'); // # for multi digits
            sb.Append(st);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) //e.g. 5#Hello5#World 
    {
        List<string> result = new();
        int i = 0;
        while (i < s.Length)
        {
            int hashIndex = s.IndexOf('#', i);
            int wordLength = int.Parse(s.Substring(i, hashIndex - i));
            string word = s.Substring(hashIndex + 1, wordLength);
            result.Add(word);
            i = hashIndex + wordLength + 1;
        }
        return result;
    }
}
