  public int LastStoneWeight(int[] stones)
        {
            
            int i = 0,temp = 0;
            if(stones == null)
            {
                return 0;
            }
            if(stones.Length == 1)
            {
                return stones[0];
            }
            while (i <= stones.Length )
            {
                Array.Sort(stones,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));
                temp = Math.Abs(stones[0] - stones[1]);
                stones[0] = temp;
                stones[1] = 0;
                i++;
            }

            return temp;
        }