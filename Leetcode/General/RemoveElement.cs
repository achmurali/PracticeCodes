//https://leetcode.com/problems/remove-element/
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int length = 0;
        int index = -1;
        for(int i = 0;i < nums.Length;i++){
            if(nums[i] != val){
                index++;
                int temp = nums[index];
                nums[index] = nums[i];
                nums[i] = temp;
            }
        }
        return index+1;
    }
}a