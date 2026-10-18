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
    public bool IsValidBST(TreeNode root) {
        return validate(root,int.MinValue,int.MaxValue);
    }
    private bool validate (TreeNode node, int min,int max){
        if(node==null){
            return true;
        }
        if(node.val <= min || node.val >= max){
            return false;
        }
        return validate(node.left,min,node.val) && validate(node.right,node.val,max);
    }
}
