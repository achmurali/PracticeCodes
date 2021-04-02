//https://leetcode.com/problems/maximum-units-on-a-truck/
public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        int res = 0;
        for(int i = 0;i < boxTypes.Length && truckSize != 0 ;i++){
            int maxIndex = i;
            for(int j = 0;j < boxTypes.Length;j++){
                if(boxTypes[maxIndex][1] < boxTypes[j][1])
                    maxIndex = j;
            }
            if(truckSize > 0){
                var contribution = 0;
                contribution = Math.Min(boxTypes[maxIndex][0],truckSize);
                truckSize -= contribution;
                res += (boxTypes[maxIndex][1] * contribution);
            }
            boxTypes[maxIndex][0] = 0;
            boxTypes[maxIndex][1] = 0;
        }
        return res;
    }
}