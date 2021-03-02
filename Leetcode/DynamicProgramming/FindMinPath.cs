//https://leetcode.com/problems/minimum-path-sum/
public class Solution {
    public int MinPathSum(int[][] grid) {
        return FindMinPath(grid,0,0);
    }

    //Brute Force Recursion
    private int FindMinPath(int[][] grid,int i,int j){
        if(i >= grid.Length || j >= grid[0].Length)
            return -1;
        int res = grid[i][j];
        int right = FindMinPath(grid,i,j+1);
        int down = FindMinPath(grid,i+1,j);
        if(right != -1 && down != -1)
            res = res + Math.Min(right,down);
        else if(right != -1)
            res = res + right;
        else if(down != -1)
            res = res + down;
        return res;
    }

    //Dymanic Programming
    private int MinPathSum1(int[][] grid) {
        int[][] dp = new int[grid.Length][];
        int m = grid.Length;
        int n = grid[0].Length;
        for(int i = 0;i < grid.Length;i++)
            dp[i] = new int[grid[0].Length];
        dp[0][0] = grid[0][0];
        for(int i = 1;i < m;i++)
            dp[i][0] = dp[i-1][0] + grid[i][0];
        for(int i = 1;i < n;i++)
            dp[0][i] = dp[0][i-1] + grid[0][i];
        for(int i = 1;i<m;++i)
        {
            for(int j = 1;j<n;++j)
                dp[i][j] = grid[i][j] + Math.Min(dp[i-1][j],dp[i][j-1]);
        }
        return dp[m-1][n-1];
    }

    /*
        As can be seen, each time when we update sum[i][j], we only need sum[i - 1][j] (at the current column)
        and sum[i][j - 1] (at the left column). So we need not maintain the full m*n matrix.
        Maintaining two columns is enough and now we have the following code.

        class Solution {
        public:
            int minPathSum(vector<vector<int>>& grid) {
                int m = grid.size();
                int n = grid[0].size();
                vector<int> pre(m, grid[0][0]);
                vector<int> cur(m, 0);
                for (int i = 1; i < m; i++)
                    pre[i] = pre[i - 1] + grid[i][0];
                for (int j = 1; j < n; j++) {
                    cur[0] = pre[0] + grid[0][j];
                    for (int i = 1; i < m; i++)
                        cur[i] = min(cur[i - 1], pre[i]) + grid[i][j];
                    swap(pre, cur); 
                }
                return pre[m - 1];
            }
        };

        Further inspecting the above code, it can be seen that maintaining pre is for recovering pre[i],
        which is simply cur[i] before its update. So it is enough to use only one vector.
        Now the space is further optimized and the code also gets shorter.

        class Solution {
        public:
            int minPathSum(vector<vector<int>>& grid) {
                int m = grid.size();
                int n = grid[0].size();
                vector<int> cur(m, grid[0][0]);
                for (int i = 1; i < m; i++)
                    cur[i] = cur[i - 1] + grid[i][0];
                for (int j = 1; j < n; j++) {
                    cur[0] += grid[0][j];
                    for (int i = 1; i < m; i++)
                        cur[i] = min(cur[i - 1], cur[i]) + grid[i][j];
                }
                return cur[m - 1];
            }
        };
    */
}