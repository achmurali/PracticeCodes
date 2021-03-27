//https://leetcode.com/problems/partition-array-for-maximum-sum/
public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int K) {
        int[] dp = new int[arr.Length];
        for(int i = 0;i < arr.Length;i++){
            int max = 0;
            for(int j = 0;j < K;j++){
                
                if(i - j < 0)
                    break;
                
                var prevSum = i - (j + 1) >= 0 ? dp[i - (j+1)]:0;
                max = Math.Max(max,arr[i-j]);
                prevSum += max*(j+1);
                dp[i] = Math.Max(dp[i],prevSum);
            }
        }
        return dp[arr.Length - 1];
    }
}