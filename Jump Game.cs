 public bool CanJump(int[] nums) {
        int length = nums.Length, maxindex =0;
        for(int i=0 ; i < length; i++){
            if(maxindex < i)
                return false;
            maxindex = Math.Max(maxindex,i+nums[i]);
        }
        return true;
    }