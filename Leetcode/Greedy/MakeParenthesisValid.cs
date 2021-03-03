//https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
public class Solution {
    public int MinAddToMakeValid(string S) {
        Stack<char> stack = new Stack<char>();
        int count = 0;
        for(int i = 0;i < S.Length;i++)
        {
            if(S[i] == '(')
                stack.Push(S[i]);
            else if(S[i] == ')' && stack.Count > 0 && stack.Peek() == '('){
                stack.Pop();
            }
            else
                ++count;
        }
        return stack.Count + count;
    }
}