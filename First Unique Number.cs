   public class FirstUnique
    {
        Dictionary<int, int> dict;
        Queue<int> queue;
        public FirstUnique(int[] nums)
        {
            dict = new Dictionary<int, int>();
            queue = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = 0;
                dict.TryGetValue(nums[i], out temp);
                dict[nums[i]] = temp + 1;
                queue.Enqueue(nums[i]);
            }
        }

        public int ShowFirstUnique()
        {
            while (queue.Count != 0 && dict[queue.Peek()] > 1)
                queue.Dequeue();

            if (queue.Count == 0)
                return -1;
            return queue.Peek();
        }

        public void Add(int value)
        {
            int temp = 0;
            dict.TryGetValue(value, out temp);
            dict[value] = temp + 1;
            if (dict[value] == 1)
                queue.Enqueue(value);
        }
    }