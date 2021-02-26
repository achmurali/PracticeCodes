//https://leetcode.com/problems/count-sorted-vowel-strings/


// Using Combinations
public class Solution {
    public int CountVowelStrings(int n) {
        return ((n+1) * (n+2) * (n+3) * (n+4)/(4*3*2));
    }
}

//Using Bottom-Up 2D DP
public class Solution {
    public int CountVowelStrings(int n) {
        int[][] dp = new int[n+1][];
        for(int i = 0;i < n+1;i++)
            dp[i] = new int[6];
        for(int i = 1;i <= n;i++)
        {
            for(int j = 1; j <= 5;j++)
            {
                dp[i][j] = dp[i][j-1] + (i > 1 ? dp[i-1][j] : 1);
            }
        }
        return dp[n][5];
    }
}