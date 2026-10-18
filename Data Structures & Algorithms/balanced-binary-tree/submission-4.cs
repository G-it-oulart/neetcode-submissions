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
    public bool IsBalanced(TreeNode root) {
        if(MaxDepth(root)==-1){
            return false;
        }
        return true;
    }
    public int MaxDepth(TreeNode root) {
    if(root==null){
        return 0;
    } 
    int leftDepth = MaxDepth(root.left);
    if(leftDepth==-1){
        return -1;
    }
    int rightDepth = MaxDepth(root.right);
    if(rightDepth==-1){
        return -1;
    }
    if(leftDepth-rightDepth>1){
        return -1;
    } else if(rightDepth - leftDepth>1){
        return -1;
    }
    return Math.Max(leftDepth,rightDepth)+1;
    }
}