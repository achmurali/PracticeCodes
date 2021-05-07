//https://leetcode.com/problems/search-insert-position/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        int mid = (l + r)/2;
        while(l <= r){
            if(target > nums[mid])
                l = mid + 1;
            else if(target < nums[mid])
                r = mid - 1;
            else if(nums[mid] == target)
                return mid;
            mid = (l+r)/2;
        }
        return l;
    }
}

// int res = 0, i = 0;
// if(target <= nums[0])
//     return 0;
// for(i = 1;i < nums.Length;i++){
//     if(nums[i] == target)
//         return i;
//     else if(nums[i-1] < target && nums[i]>target)
//         return i;
// }
// return i;