//https://leetcode.com/problems/implement-strstr/
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle == "")
            return 0;
        if(haystack.Length < needle.Length)
            return -1;
        for(int i = 0;i <= haystack.Length - needle.Length;i++){
            int temp = i;
            int j = 0;
            for(j = 0;j < needle.Length;j++){
                if(needle[j] == haystack[i+j]){
                }
                else
                    break;
            }
            if(j == needle.Length)
                return temp;
        }
        return -1;
    }
}