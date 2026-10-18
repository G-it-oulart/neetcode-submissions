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
    List<int> values = new List<int>();
    public int GoodNodes(TreeNode root) {
        values.Add(root.val);
        findGoodNodes(root, root.left);
        findGoodNodes(root, root.right);
        return values.Count;
    }

    public void findGoodNodes(TreeNode upperNode, TreeNode node) {
        if (node == null) {
            return;
        }
        if (upperNode.val <= node.val) {
            values.Add(node.val);
            findGoodNodes(node, node.left);
            findGoodNodes(node, node.right);
        } else {
            findGoodNodes(upperNode, node.left);
            findGoodNodes(upperNode, node.right);
        }
        return;
    }
}
