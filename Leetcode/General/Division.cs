//https://leetcode.com/problems/divide-two-integers/
public class Solution {
    public int Divide(int dividend, int divisor) {
        int result = 0;
        int divisor_abs = Math.Abs(divisor);
        if(divisor_abs == 1)
            result = divisor * dividend;
        else{
            while(dividend >= divisor_abs){
                result++;
                dividend-=divisor_abs;
            }
            result = (Math.Abs(divisor)/divisor) * result;
        }
        if(result > 2147483647 || result <= -2147483648)
            return 2147483647;
        
        return result;
        }
}