//https://leetcode.com/problems/largest-number/

public class Solution
{    public string LargestNumber(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0].ToString();

        var nums_string = nums.Select((num) => num.ToString()).ToList();

        for (int i = 0; i < nums_string.Count; i++)
        {
            for (int j = 1; j < nums_string.Count; j++)
            {
                if ((nums_string[j] + nums_string[j - 1]).CompareTo(nums_string[j - 1] + nums_string[j]) > 0)
                {
                    var temp = nums_string[j - 1];
                    nums_string[j - 1] = nums_string[j];
                    nums_string[j] = temp;
                }
            }
        }

        if (nums_string[nums_string.Count - 1] == "0" && nums_string[0] == "0")
            return "0";

        var res = "";
        return nums_string.Aggregate((res, str) => res + str);
    }

    private void findGreater(string s1, string s2)
    {

    }
}