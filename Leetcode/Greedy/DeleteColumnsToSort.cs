//https://leetcode.com/problems/delete-columns-to-make-sorted/
public class Solution {
    public int MinDeletionSize(string[] strs) {
        int m = strs.Length;
        int n = strs[0].Length;
        int res = 0;
        for(int i = 0;i < n;i++)
        {
            for(int j = 1;j < m ;j++){
                if(strs[j][i] < strs[j-1][i])
                {
                    ++res;
                    break;
                }
            }
        }
        return res;
    }
}