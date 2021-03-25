//https://leetcode.com/problems/check-if-a-string-can-break-another-string/

public class Solution {
    public bool CheckIfCanBreak(string s1, string s2) {
        s1 = new string(s1.OrderBy(c => c).ToArray());
        s2 = new string(s2.OrderBy(c => c).ToArray());
        if(s1[0] > s2[0])
        {
            return CompareStrings(s1,s2);
        }
        else if(s2[0] > s1[0]){
            return CompareStrings(s2,s1);
        }
        else{
            int i = 0;
            while(s1[i] == s2[i]){
                s1 = s1.Remove(i,1);
                s2 = s2.Remove(i,1);
            }
            if(s1[0] > s2[0])
            {
                return CompareStrings(s1,s2);
            }
            else{
                return CompareStrings(s2,s1);
            }
        }
    }

    private bool CompareStrings(string s1,string s2){
        for(int i = 0;i < s1.Length;i++){
            if(s1[i] < s2[i])
                return false;
        }
        return true;
    }
}   