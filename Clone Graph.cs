/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<Node,Node> visitedNode = new Dictionary<Node,Node>();
    public Node CloneGraph(Node node) {
        if (node == null) {
            return node;
        }
        
        if(visitedNode.ContainsKey(node)){
            return visitedNode[node];
        }
        Node newNode = new Node(node.val);
        visitedNode.Add(node, newNode);
        foreach(var neighbor in node.neighbors){
                newNode.neighbors.Add(CloneGraph(neighbor));
        }
        return newNode;
        
    }
    
    
}