public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0)
            return 0;
        int length = 1;
        int memory = nums[0];
        int lindex = 0;
        for(int i=1;i < nums.Length;i++){
            if(nums[i] != memory){
                lindex++;
                length++;
                memory = nums[i];
                //swap
                if(lindex != i){
                    nums[lindex] = nums[i];
                    nums[i] = -1;
                }
            }
        }
        return length;
    }
}