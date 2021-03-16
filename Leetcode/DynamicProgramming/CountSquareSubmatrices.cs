//https://leetcode.com/problems/count-square-submatrices-with-all-ones/

public class Solution {
    public int CountSquares(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int res = 0;
        for(int i = 0;i < rows;i++){
            for(int j = 0;j < cols;j++)
            {
                if(matrix[i][j] == 1)
                {
                    if(i == 0 || j == 0)
                        res += 1;
                    else{
                        var cell_val = Math.Min(matrix[i-1][j-1],Math.Min(matrix[i-1][j],matrix[i][j-1])) + matrix[i][j];
                        res += cell_val;
                        matrix[i][j] = cell_val;
                    }
                }
            }
        }
        return res;
    }
}