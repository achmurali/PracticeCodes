//https://leetcode.com/problems/word-break/

public class Solution {
        private HashSet<int> lengths = new HashSet<int>();

        public bool WordBreak(string s, IList<string> wordDict)
        {
            foreach (var ele in wordDict)
                lengths.Add(ele.Length);
            return wb(s, wordDict);
        }

        private bool wb(string s, IList<string> wordDict)
        {
            if (s.Length == 0)
                return true;

            foreach (var length in lengths)
            {
                if (s.Length >= length && wordDict.Contains(s.Substring(0,length)) && wb(s.Substring(length), wordDict))
                {
                    return true;
                }
            }
            return false;
        }
}