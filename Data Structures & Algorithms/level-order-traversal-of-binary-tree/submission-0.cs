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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root==null){
            return [];
        }
        List<List<int>> answerList = new List<List<int>>();
        List<int> nodesList = new List<int>();
        Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
        nodeQueue.Enqueue(root);
        while (nodeQueue.Count > 0) {
            int startingCount = nodeQueue.Count;
            for (int i = 0; i < startingCount; i++) {
                TreeNode node = nodeQueue.Dequeue();
                if(node.left!=null){
                    nodeQueue.Enqueue(node.left);
                } 
                if(node.right!=null){
                    nodeQueue.Enqueue(node.right);
                }
                nodesList.Add(node.val);
            }
            List<int> copyList = new List<int>(nodesList);
            answerList.Add(copyList);
            nodesList.Clear();
        }
        return answerList;
    }
}
