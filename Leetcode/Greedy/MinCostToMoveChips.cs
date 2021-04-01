//https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/
public class Solution {
    public int MinCostToMoveChips(int[] position) {
        IList<int> positions = new List<int>();
        for(int i = 0;i < position.Length;i++)
            positions.Add(position[i]);
        int res = Int32.MaxValue;
        for(int i = 0;i < positions.Count;i++){
            int currValue = 0; 
            for(int j = 0;j < positions.Count;j++){
                int cost = (Math.Abs(positions[j]-positions[i]) % 2 == 0) ? 0 : Math.Abs(positions[j]-positions[i]);
                currValue += (cost%2); 
        }
        if(res > currValue)
            res = currValue;
        }
        return res;
    }
}