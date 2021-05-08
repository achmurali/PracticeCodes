//https://leetcode.com/problems/roman-to-integer/

public class Solution {
    private int translateRoman(Char roman){
        switch(roman){
            case 'I':return 1;
            case 'V':return 5;
            case 'X':return 10;
            case 'L':return 50;
            case 'C':return 100;
            case 'D':return 500;
            case 'M':return 1000;
        }
        return 0;
    }
    public int RomanToInt(string s) {
            int res = translateRoman(s[0]);
            int prev = res;
            for (int i = 1; i < s.Length; i++)
            {
                int curr = translateRoman(s[i]);
                if (prev == -1 || prev >= curr)
                    res = res + curr;
                else if (prev != -1)
                {
                    res += (curr - prev * 2);
                }
                prev = curr;
            }
            return res;
    }
}