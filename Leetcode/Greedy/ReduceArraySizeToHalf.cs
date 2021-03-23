//https://leetcode.com/problems/reduce-array-size-to-the-half/
public class Solution {
    public int MinSetSize(int[] arr) {
        Dictionary<int,int> count_dict = new Dictionary<int,int>();
        int res = 0;
        int count = 0;
        for(int i = 0;i < arr.Length;i++)
        {
            if(count_dict.ContainsKey(arr[i]))
            {
                count_dict[arr[i]] += 1;
            }
            else
                count_dict.Add(arr[i],1);
        }
        var values_list = count_dict.ToList();
        values_list.Sort((x,y) => y.Value - x.Value);
        for(int i = 0;i < values_list.Count;i++){
            if(count >= arr.Length/2)
                return res;
            else{
                count += values_list[i].Value;
                res += 1;
            }
        }
        return res;
    }
}