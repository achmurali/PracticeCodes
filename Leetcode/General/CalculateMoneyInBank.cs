// https://leetcode.com/problems/calculate-money-in-leetcode-bank/
public class Solution {
    public int TotalMoney(int n) {
        
        int[] weekSum = new int[]{1,3,6,10,15,21,28};
        int noOfWeeks = n / 7;
        int leftOverDays = n % 7;
        if(noOfWeeks < 1)
            return weekSum[n-1];
        var leftOverDaysSum = leftOverDays == 0 ? 0 : weekSum[leftOverDays - 1]; 
        return (noOfWeeks*weekSum[6] + (((noOfWeeks-1)*noOfWeeks)/2*7) + leftOverDaysSum + (leftOverDays * (noOfWeeks)));
    }
}