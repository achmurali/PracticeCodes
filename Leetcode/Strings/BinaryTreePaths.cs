//https://leetcode.com/problems/binary-tree-paths/

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
public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
        
        HashSet<string> result = new HashSet<string>();
        if(root == null)
            return result.ToList();
        
        if(root.left == null && root.right == null){
            result.Add(root.val.ToString());
            return result.ToList();
        }
        
        if(root.right != null) ConstructString(root.right,root.val.ToString(),result);
        if(root.left != null) ConstructString(root.left,root.val.ToString(),result);
        
        return result.ToList();
    }
    
    private void ConstructString(TreeNode root, string path,HashSet<string> result){
        
        if(root == null)
            return;
        
        if(root.right == null && root.left == null){
            result.Add(path + "->" + root.val);
            return;
        }
        
        ConstructString(root.right, path + "->" + root.val, result);
        ConstructString(root.left, path + "->" + root.val, result);
                
    }
}