public class Solution {
    public int ArrayNesting(int[] nums) {
        int maxLength = 0;
       for(int i=0; i < nums.Length; i++){
           if(nums[i] != -1){
           int j = i;
           int length=0;
           while(j != i || length ==0){
               length++;
               int temp = nums[j];
               nums[j] = -1;
               j = temp;
               
           }
           maxLength = Math.Max(maxLength, length);
           }
           
       }
        return maxLength;
    }
}