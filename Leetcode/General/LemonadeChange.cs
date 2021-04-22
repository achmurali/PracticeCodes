//https://leetcode.com/problems/lemonade-change/
public class Solution {
        public bool LemonadeChange(int[] bills)
        {
            int account = 0;
            int[] notes = new int[4];
            notes[2] = -1;
            for (int i = 0; i < bills.Length; i++)
            {
                int change = bills[i] - 5;
                if (change > account || checkNotes(notes, change))
                    return false;
                account -= change;
                notes[bills[i] / 5 - 1] += 1;
                account += bills[i];
            }

            return true;
        }

        private bool checkNotes(int[] notes,int change){
            if (change == 0) return false;
            for (var i = 3; i >= 0; --i)
            {
                if (notes[i] <= 0 || ((i + 1) * 5) > change) continue;
                var div = Math.Min(notes[i], change / ((i + 1) * 5));
                notes[i] -= div;
                change -= div * ((i + 1) * 5);
            }
            return change != 0;
        }
}