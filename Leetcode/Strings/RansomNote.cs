
//https://leetcode.com/problems/ransom-note/
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] magazineCount = new int[26];
        for(int i = 0;i < magazine.Length;i++){
            magazineCount[magazine[i] - 'a'] += 1;
        }
        
        for(int i = 0;i < ransomNote.Length;i++){
            if(magazineCount[ransomNote[i] - 'a'] > 0)
                magazineCount[ransomNote[i] - 'a'] -= 1;
            else
                return false;
        }
        return true;
    }
}