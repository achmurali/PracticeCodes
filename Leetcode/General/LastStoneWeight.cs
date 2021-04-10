//https://leetcode.com/problems/last-stone-weight/
public class Solution {
        public int LastStoneWeight(int[] arr)
        {
            int i = 1;
            int residual = 0;
            sortStones(arr);
            int count = arr.Length - 1;
            while (count-- > 0)
            {
                residual = arr[i-1] - arr[i];
                if (residual == 0)
                    arr[i] = 0;
                else
                    arr[i] = residual;
                arr[i-1] = 0;
                sortStones(arr);
            }
            return arr[0];
        }

        private void sortStones(int[] arr)
        {
            
            for (int i = 1;i < arr.Length;i++)
            {
                for (int j = i - 1; j >= 0 && arr[j] < arr[j+1]; j--)
                {
                    int temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
}