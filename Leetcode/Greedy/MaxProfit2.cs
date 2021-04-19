public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        for(int i = 0;i<prices.Length - 1;i++){
            if(prices[i] < prices[i+1])
                res += prices[i+1] - prices[i];
        }
        return res;
    }
}