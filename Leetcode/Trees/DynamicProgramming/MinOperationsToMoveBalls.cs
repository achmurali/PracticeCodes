//https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
public class Solution {
    public int[] MinOperations(string boxes) {
        var result = new List<int>();
        for(int i = 0;i < boxes.Length; i++)
        {
            int res = 0;
            for(int j = 0;j < boxes.Length; j++)
            {
                if(boxes[j] == '1')
                {
                    res += Math.Abs(i - j);
                }
            }
            result.Add(res);
        }
        return result.ToArray();
    }
}