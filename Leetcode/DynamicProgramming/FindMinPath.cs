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
}