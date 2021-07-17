//https://leetcode.com/problems/word-pattern/

public class Solution {
    public bool WordPattern(string pattern, string s) {
        //Console.WriteLine(s.Split(" ").Length);
        if(pattern.ToCharArray().Length != s.Split(" ").Length)
            return false;
        
        Dictionary<string,char> patternMap = new Dictionary<string,char>();
        string[] arr = new string[26];
        var words = s.Split(" ");
        for(int i = 0;i < words.Length; i++){
            if(!patternMap.ContainsKey(words[i])){
                
                if(arr[pattern[i] - 'a'] != null)
                    return false;
                
                arr[pattern[i] - 'a'] = words[i];
                patternMap.Add(words[i],pattern[i]);
            }    
            else{
                if(pattern[i] != patternMap[words[i]])
                    return false;
            }
        }
        
        return true;
    }
}