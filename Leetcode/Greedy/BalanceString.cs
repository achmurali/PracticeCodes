//https://leetcode.com/problems/split-a-string-in-balanced-strings/
public class Solution {
    public int BalancedStringSplit(string s) {
        int countL = 0, countR = 0;
        int res = 0;
        for(int i = 0;i < s.Length;i++)
        {
            var temp = s[i] == 'L' ? ++countL : ++countR;
            if(countL == countR)
                res++;
        }
        return res;
    }
}