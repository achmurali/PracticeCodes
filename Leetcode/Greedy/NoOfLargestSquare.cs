//https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/
public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        Dictionary<int,int> lengths_dict = new Dictionary<int,int>();
        var max = -1;
        for(int i = 0;i < rectangles.Length;i++){
            var curr_max = Math.Min(rectangles[i][0],rectangles[i][1]);
            if(curr_max > max)
                max = curr_max;
            if(lengths_dict.ContainsKey(curr_max)){
                lengths_dict[curr_max] += 1;
            }
            else{
                lengths_dict.Add(curr_max,1);
            }
        }
        return lengths_dict[max];
    }
}