//https://leetcode.com/problems/letter-combinations-of-a-phone-number/

public class Solution {
    private static Dictionary<string, string> phoneDict = new Dictionary<string, string>{
        {"2","abc"},
        {"3","def"},
        {"4","ghi"},
        {"5","jkl"},
        {"6","mno"},
        {"7","pqrs"},
        {"8","tuv"},
        {"9","wxyz"}
    };

    private IList<string> result = new List<string>();
    
    public IList<string> LetterCombinations(string digits) {
        if(digits.Length == 0)
            return result;
        
        LetterCombinationsUtil(digits,0,new List<char>());
        return result;
    }

    private void LetterCombinationsUtil(string digits,int index,IList<char> res)
    {
        if (index == digits.Length)
        {
            result.Add(new string(res.ToArray()));
        }

        else
        {
            for (int i = 0; i < phoneDict[digits[index].ToString()].Length; i++)
            {
                var test = phoneDict[digits[index].ToString()][i];
                res.Add(test);
                LetterCombinationsUtil(digits, index + 1, res);
                res.RemoveAt(index);
            }
        }
    }
}