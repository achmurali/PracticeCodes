//https://leetcode.com/problems/number-of-subarrays-with-bounded-maximum/
public class Solution {
    public int NumSubarrayBoundedMax(int[] arr, int L, int R) {
    int left = -1,right = -1,res = 0;
    for(int i = 0;i < arr.Length;i++)
    {
        if(arr[i] > R)left = i;
        if(arr[i] >= L)right = i;
        res += right - left;
        Console.WriteLine(res);
    }
        return res;
    }
}