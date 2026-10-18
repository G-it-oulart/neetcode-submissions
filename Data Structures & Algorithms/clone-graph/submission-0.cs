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
    Dictionary<int,Node> nodeDict = new Dictionary<int,Node>();
    public Node CloneGraph(Node node) {
        if(node==null){
            return null;
        }
        if(nodeDict.ContainsKey(node.val)){
            return nodeDict[node.val];
        }
        Node cloneNode = new Node(node.val);
        nodeDict[node.val] = cloneNode;
        foreach(var neighborNode in node.neighbors){
            cloneNode.neighbors.Add(CloneGraph(neighborNode));
        }
        return nodeDict[node.val];
    }
}
