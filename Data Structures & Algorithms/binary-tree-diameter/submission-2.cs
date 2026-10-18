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
    int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        FindDiameter(root);
        return diameter;
    }

    public int FindDiameter(TreeNode root){
        if(root==null){
            return 0;
        } 
        int leftDepth = FindDiameter(root.left);
        int rightDepth = FindDiameter(root.right);
        diameter = Math.Max(diameter,leftDepth+rightDepth);
        return Math.Max(leftDepth,rightDepth)+1;
    }
}
