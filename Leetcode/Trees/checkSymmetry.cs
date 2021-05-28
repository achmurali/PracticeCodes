//https://leetcode.com/problems/symmetric-tree/

public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root == null)
            return true;
        return checkSymmetry(root.left, root.right);
    }
    
    private bool checkSymmetry(TreeNode left, TreeNode right){
        if(left == null && right == null)
            return true;
        if(left == null || right == null)
            return false;
        if(left.val != right.val)
            return false;
        return checkSymmetry(left.left,right.right) && checkSymmetry(left.right,right.left);
    }
    
}