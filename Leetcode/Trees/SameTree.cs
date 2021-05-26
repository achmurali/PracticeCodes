//https://leetcode.com/problems/same-tree/

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return TraverseTrees(p,q);
    }
    
    private bool TraverseTrees(TreeNode p, TreeNode q){
        if(p == null && q != null || p != null && q == null)
            return false;
        else if(p == null && q == null)
            return true;
        else
            return p.val == q.val && TraverseTrees(p.left,q.left) && TraverseTrees(p.right,q.right);
    }
    
}