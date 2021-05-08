//https://leetcode.com/problems/group-anagrams/
public class Solution {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> strings = new Dictionary<string, IList<string>>();
            for(int i = 0; i < strs.Length; i++)
            {
                string temp = strs[i];
                char[] tempChar = temp.ToArray();
                Array.Sort(tempChar);
                temp = new string(tempChar);
                if (!strings.ContainsKey(temp))
                {
                    strings.Add(temp, new List<string>() { strs[i] });
                }
                else
                {
                    strings[temp].Add(strs[i]);
                }
            }
            return strings.Values.ToList();
        }
}