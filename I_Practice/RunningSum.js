/**
 * @param {number[]} nums
 * @return {number[]}
 */
var runningSum = function(nums) {
    // for(let i = 1;i < nums.length;i++)
    // {
    //     nums[i] = nums[i] + nums[i-1];
    // }
    let newNum = []
    nums.reduce((prev,curr,i) => newNum[i] = prev+curr,0);
    return newNum;
};

console.log(runningSum([3,1,2,10,1]));