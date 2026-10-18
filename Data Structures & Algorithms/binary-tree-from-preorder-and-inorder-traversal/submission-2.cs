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
    Dictionary<int,int> indexOfValues = new Dictionary<int,int>();
    int preorderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for(int i = 0; i<inorder.Length;i++){
            indexOfValues[inorder[i]] = i;
        }
        return connectNodes(inorder, preorder, 0, inorder.Length - 1);
    }

    public TreeNode connectNodes(int[] inorder, int[] preorder, int lowerBound, int upperBound) {
        if (lowerBound > upperBound) {
            return null;
        }
        int idx = indexOfValues[preorder[preorderIndex]];
        TreeNode node = new TreeNode(inorder[idx], null, null);
        preorderIndex++;
        node.left = connectNodes(inorder, preorder, lowerBound, idx-1);
        node.right = connectNodes(inorder, preorder, idx+1, upperBound);
        return node;
    }
}