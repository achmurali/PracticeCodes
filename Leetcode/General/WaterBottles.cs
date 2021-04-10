//https://leetcode.com/problems/water-bottles/
public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int res = 0;
        int residual = 0;
        while(numBottles > 0){
            numBottles += residual/numExchange;
            residual = residual % numExchange;
            res += numBottles;
            residual += numBottles % numExchange;
            numBottles = numBottles / numExchange;
        }
        res += (residual/numExchange);
        return res;
    }
}