  class LRUCache
    {
        private int capacity;
        private OrderedDictionary dict;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            this.dict = new OrderedDictionary();
        }

        public int Get(int key)
        {
            int val = 0;
            if (dict.Contains((object)key))
            {
                val = (int)dict[(object)key];
                dict.Remove((object)key);
                dict.Add(key, val);
                return val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            int val = 0;
            if (dict.Contains(key))
            {
                dict.Remove((object)key);
            }
            else if (dict.Count == capacity)
            {
                dict.RemoveAt(0);
            }
            dict.Add(key, value);
        }