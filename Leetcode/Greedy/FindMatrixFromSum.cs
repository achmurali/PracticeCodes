//https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums/
public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        int[][] res = new int[rowSum.Length][];
        for(int i = 0;i < rowSum.Length;i++)
            res[i] = new int[colSum.Length];
        for(int i = 0; i < rowSum.Length;i++)
        {
            for(int j = 0;j < colSum.Length;j++)
            {
                res[i][j] = Math.Min(colSum[j],rowSum[i]);
                colSum[j] -= res[i][j];
                rowSum[i] -= res[i][j];
            }
        }
        return res;
    }
}