//https://leetcode.com/problems/permutations/
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> temp = new List<int>(nums);
        PermuteArray(nums,res,0);
        return res;
    }
    
    private void PermuteArray(int[] nums, IList<IList<int>> res,int index){
        if(index == nums.Length)
            res.Add(new List<int>(nums));
        else
        {
            for(int i = index;i < nums.Length;i++){
                Swap(nums,index,i);
                PermuteArray(nums,res,index+1);
                Swap(nums,index,i);
            }
        }
    }
    
    private void Swap(int[] nums,int i,int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}