  public static  int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = 0, longestSubArray = 0;
            dict[0] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += (nums[i] == 1 ? 1 : -1);
                int temp = 0;
                dict.TryGetValue(sum, out temp);
                if (dict.Keys.Where(x => x == sum).Any())
                {
                    longestSubArray = Math.Max(longestSubArray, i + 1 - temp);
                }
                else
                {
                    dict[sum] = i + 1;
                }
            }
            return longestSubArray;
        }

        static int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }