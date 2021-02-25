//https://leetcode.com/problems/partition-labels/
public class Solution {
    public IList<int> PartitionLabels(string s) {
        int[] map = new int[26];
        IList<int> res = new List<int>();
        for(int i = 0;i < s.Length;++i)
            map[s[i] - 'a'] = i;
        for(int i = 0,j = 0,mm = 0; i < s.Length;i++)
        {
            mm = Math.Max(mm,map[s[i] - 'a']);
            if(mm == i){
                res.Add(i - j + 1);
                j = i + 1;
            }
        }
        return res;
    }
}