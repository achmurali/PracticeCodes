/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

//Link : https://leetcode.com/problems/search-in-a-binary-search-tree

public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root != null)
        {
            if(root.val == val)
                return root;
            else
            {
                var resultL = SearchBST(root.left,val);
                var resultR = SearchBST(root.right,val);
                if(resultL != null)
                    return resultL;
                if(resultR != null)
                    return resultR;
                return null;
            }
        }
        return null;
    }
}