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
//List - https://leetcode.com/problems/n-ary-tree-postorder-traversal
public class Solution {
    public IList<int> Postorder(Node root) {
        IList<int> nodes = new List<int>();
        postOrderTraverse(root,nodes);
        return nodes;
    }
    
    private void postOrderTraverse(Node root,IList<int> nodes)
    {
        if(root == null)
            return;
        foreach(var node in root.children)
        {
            postOrderTraverse(node,nodes);
        }
        nodes.Add(root.val);
    }
}