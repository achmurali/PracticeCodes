//https://leetcode.com/problems/stone-game/
public class Solution {
    public bool StoneGame(int[] piles) {
        return CheckChances(piles,true) || CheckChances(piles,false);
    }
    
    private bool CheckChances(int[] piles,bool isAlex){
        var arr = piles.ToList();
        int scoreAlex = 0,scoreLee = 0;
        int chance = 0;
        while(arr.Count > 0){
            int max = GetMax(arr);
            if(chance%2 == 0){
                if(isAlex) 
                    scoreAlex += max; 
                else
                    scoreLee += max;
            }
            else{
                
                if(isAlex) 
                    scoreAlex += max; 
                else
                    scoreLee += max;
            }
            ++chance;
        }
        if(scoreAlex > scoreLee)
            return true;
        return false;
    }
    
    private int GetMax(List<int> arr){
        var list = arr.ToList();
        int max = 0;
        int index = 0;
        if(arr[0] > arr[arr.Count - 1]){
            max = arr[0];
            index = 0;
        }
        else{
            max = arr[arr.Count-1];
            index = arr.Count - 1;
        }
        arr.RemoveAt(index);
        return max;
    }
}