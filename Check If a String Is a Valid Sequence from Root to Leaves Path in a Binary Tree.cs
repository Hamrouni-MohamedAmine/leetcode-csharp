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
    int length;
    public bool IsValidSequence(TreeNode root, int[] arr) {
         length = arr.Length;
         return visitNode(root ,arr,0);
    }
    
    public bool visitNode(TreeNode node,int[] arr,int index){
          if(node == null)
            return false;
        
        if(index == length - 1)
            return (node.val == arr[index] && (node.left == null && node.right == null));
            
        
        if(node.val == arr[index])
            return visitNode(node.left,arr,index + 1) || visitNode(node.right,arr,index + 1);
        
        return false;
    }
}