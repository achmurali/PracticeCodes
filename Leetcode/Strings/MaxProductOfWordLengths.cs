//https://leetcode.com/problems/maximum-product-of-word-lengths/

public class Solution {
        private IList<Tuple<int,HashSet<char>>> sets;

        public int MaxProduct(string[] words) {
            buildSets(words);
            int max = 0;
            for(int i = 0;i < sets.Count; i++)
            {
                for (int j = i + 1;j < sets.Count; j++)
                {
                    var intersect = sets[i].Item2.Intersect(sets[j].Item2);
                    if (intersect.ToList().Count == 0)
                    {
                        var length = words[sets[i].Item1].Length * words[sets[j].Item1].Length;
                        if (max < length)
                            max = length;
                    }
                }
            }
            return max;
        }

        private void buildSets(string[] words)
        {
            sets = new List<Tuple<int, HashSet<char>>>();
            for (int i = 0; i < words.Length; i++)
            {
                HashSet<char> set = new HashSet<char>();
                
                for(int j = 0; j < words[i].Length; j++)
                {
                    set.Add(words[i][j]);
                }

                sets.Add(new Tuple<int,HashSet<char>>(i,set));
            }
        }
}