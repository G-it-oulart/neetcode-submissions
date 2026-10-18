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
    int count = 0;
    int kVal = 0;
    public int KthSmallest(TreeNode root, int k) {
        findSmallest(root, k);
        return kVal;
    }
    public int findSmallest(TreeNode root, int k) {
        if (root == null) {
            return 0;
        }
        findSmallest(root.left, k);
        count++;
        if(count==k){
            kVal = root.val;
        }
        findSmallest(root.right, k);
        return count;
    }
}
