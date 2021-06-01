//https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/

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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        
        IList<IList<int>> result = new List<IList<int>>();
        if(root == null)
            return result;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int flag = 1;
        while(queue.Count != 0){
            List<int> list = new List<int>();
            var n = queue.Count;
            while(n-- > 0){
                var node = queue.Dequeue();
                list.Add(node.val);
                AddNodes(node.right,node.left,queue);
            }
            if(flag%2!=0){
                list.Reverse();
            }
            result.Add(list);
            flag++;
        }
            return result;
        }
    
    private void AddNodes(TreeNode node1, TreeNode node2,Queue<TreeNode> queue){
        if(node1!=null)
            queue.Enqueue(node1);
        if(node2!=null)
            queue.Enqueue(node2);
    }
}