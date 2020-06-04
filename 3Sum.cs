public static IList<IList<int>> ThreeSum (int[] nums, int target) {
    IList<IList<int>> result = new List<IList<int>> ();
    Array.Sort (nums);
    for (int i = 0; i < nums.Length - 2; i++) {
        if (i != 0 && nums[i] == nums[i - 1])
            continue;

        int left = i + 1;
        int right = nums.Length - 1;
        while (left < right) {
            int sum = nums[i] + nums[left] + nums[right];
            if (sum < target) {
                left++;
            } else if (sum > target) {
                right--;
            } else {
                result.Add (new List<int> () { nums[i], nums[left], nums[right] });
                left++;
                right--;

                while (left < right && nums[left] == nums[left - 1]) {
                    left++;
                }

                while (left < right && nums[right] == nums[right + 1]) {
                    right--;
                }
            }
        }

    }

    return result;
}