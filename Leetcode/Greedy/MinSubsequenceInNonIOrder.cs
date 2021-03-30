//https://leetcode.com/problems/minimum-subsequence-in-non-increasing-order/
public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        var list = nums.ToList();
        var sum = list.Sum();
        
        list.Sort((a,b) => b-a);
        int res = 0;
        IList<int> resList = new List<int>();
        foreach(var i in list){
            res += i;
            resList.Add(i);
            if(res > (sum - res))
                return resList;
        }
        return null;
    }
}