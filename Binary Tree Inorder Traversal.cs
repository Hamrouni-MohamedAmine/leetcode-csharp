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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> lst = new List<int>();
        DFS(root,lst);
        return lst;
        
    }
    
    public void DFS(TreeNode node, List<int> lst){
        if(node == null){
            return ;
        }
       
        DFS(node.left,lst);
        lst.Add(node.val);
        DFS(node.right,lst);
         
    }
}