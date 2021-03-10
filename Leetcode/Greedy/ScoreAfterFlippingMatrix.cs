//https://leetcode.com/problems/score-after-flipping-matrix/
public class Solution {
    public int MatrixScore(int[][] A) {
        int m = A.Length;
        int n = A[0].Length;
        int result = 0;
        result += (1 << (n-1))*m;
        for(int j = 1;j < n;j++)
        {
            int same = 0;
            for(int i = 0;i < m;i++)
            {
                if(A[i][j] == A[i][0])
                    same++;
            }
            result += (1 << (n-1-j))*Math.Max(same,m-same);
        }
        return result;
    }
}