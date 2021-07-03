//https://leetcode.com/problems/palindrome-partitioning/

public class Solution {
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> res = new List<IList<string>>();
        Stack<string> par = new Stack<string>();
        PalindromePartitionUtil(s, 0, res, par);
        return res;
    }
    
    private void PalindromePartitionUtil(string s,int index,IList<IList<string>> res,Stack<string> par)
    {
        if(s.Length == index)
        {
            res.Add(par.Reverse().ToList());
        }
        else
        {
            for(int i = index;i < s.Length; i++)
            {
                if (IsPalindrome(s,index,i)) 
                {
                    par.Push(s.Substring(index, i - index + 1));
                    PalindromePartitionUtil(s, i + 1, res, par);
                    par.Pop();
                }
            }
        }
    }


    private bool IsPalindrome(string s,int l,int r)
    {
        while(l < r)
        {
            if (s[l++] != s[r--])
                return false;
        }
        return true;
    }
}