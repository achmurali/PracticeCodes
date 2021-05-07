//https://leetcode.com/problems/rotate-image/
public class Solution {
    
    private void swap(ref int i,ref int j){
        int temp = i;
        i = j;
        j = temp;
    }
    
    public void Rotate(int[][] matrix) {
        for(int i = 0;i < matrix.Length;i++){
            for(int j = i + 1;j < matrix[0].Length;j++){
                swap(ref matrix[i][j],ref matrix[j][i]);
            }
        }
        for(int i=0;i<matrix.Length;i++){
            Array.Reverse(matrix[i]);
        }
    }
}