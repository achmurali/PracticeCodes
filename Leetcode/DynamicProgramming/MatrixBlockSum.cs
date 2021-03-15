//https://leetcode.com/problems/matrix-block-sum/
public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int K) {
        int m = mat.Length;
        int n = mat[0].Length;
        int[][] dp = new int[m+1][];
        for(int i = 0; i <= m;i++)
            dp[i] = new int[n+1];
        for(int i = 1;i <= m;i++)
        {
            for(int j = 1;j <= n;j++)
            {
                dp[i][j] = mat[i-1][j-1] + dp[i-1][j] + dp[i][j-1] - dp[i-1][j-1];
            }
        }
        int[][] soln = new int[m][];
        for(int i = 0;i < m;i++)
            soln[i] = new int[n];
        for(int i = 0;i < m;i++)
        {
            for(int j = 0;j < n;j++){
                int r1 = Math.Max(0,i - K),c1 = Math.Max(0,j - K);
                int r2 = Math.Min(m-1,i+K),c2 = Math.Min(n-1,j+K);
                r1++; c1++; r2++; c2++;
                soln[i][j] = dp[r2][c2] - dp[r2][c1-1] - dp[r1 - 1][c2] + dp[r1-1][c1-1];
            }
        }
        return soln;
    }
}