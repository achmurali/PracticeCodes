//https://leetcode.com/problems/longest-palindromic-substring/
public class Solution {
    private int low,maxLen;

    //DP Solution
    public string LongestPalindrome(string s) {
        int n = s.Length;
        if(n <= 0)
            return "";
        string res = "";
        res+=s[0];
        bool[][] dp = new bool[n][];
        for(int i = 0;i < n;i++)
            dp[i] = new bool[n];
        for(int i = 0;i < n;i++)
            dp[i][i] = true;
        for(int i = n-1;i >= 0;i--)
        {
            for(int j = i+1;j < n;j++){
                if(s[i] == s[j])
                {
                    if(j - i == 1 || dp[i+1][j-1])
                    {
                        dp[i][j] = true;
                        if(res.Length < (j-i+1))
                            res = s.Substring(i,j-i+1);
                    }
                }
            }
        }
        return res;
    }

    private void ExpandRange(string s,int left,int right)
    {
        while(s[left] == s[right])
        {
            left--;
            right++;
        }
        if(maxLen > right - left - 1){
            low = left - 1;
            maxLen = right - left - 1;
        }
    }

    //Expand from middle solution
    public string LongestPalindrome1(string s){
        for(int i = 0;i < n;i++)
        {
            ExpandRange(s,i,i);
            ExpandRange(s,i,i+1);
        }
        return s.Substring(s,lo,maxLen);
    }
}