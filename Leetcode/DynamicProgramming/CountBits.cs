//https://leetcode.com/problems/counting-bits/
class Solution{
  public int[] CountBits(int num){
  int[] dp = new int[num+1];
  for(int i = 1;i < num+1;++i){
    dp[i] = dp[i >> 1] + (i&1);
  }
  return dp;
  }
  
  public int[] CountBits1(int num){
  int[] dp = new int[num+1];
  int offset = 1;
  for(int i = 0;i < num + 1;+i){
    if(offset * 2 == i)
      offset *= 2;
    dp[i] = dp[i - offset] + 1;
  }
  return dp;
  }
}
