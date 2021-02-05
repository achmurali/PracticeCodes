/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/
//Link : https://leetcode.com/problems/n-ary-tree-level-order-traversal

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> nodes = new List<IList<int>>();
        levelOrderTraversal(root,nodes,0);
        return nodes;
    }
    
    private void levelOrderTraversal(Node root, IList<IList<int>> nodes,int level)
    {
        if(root == null)
            return;
        
        if(nodes.Count <= level)
            nodes.Add(new List<int>());
        
        nodes[level].Add(root.val);
        foreach(var node in root.children)
        {
            levelOrderTraversal(node,nodes,level+1);
        }
        
    }
}