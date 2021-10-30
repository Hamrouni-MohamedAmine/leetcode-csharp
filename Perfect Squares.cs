public class Solution {
    public int NumSquares(int n) {
         List<int> square_nums = new List<int>();
    for (int i = 1; i * i <= n; ++i) {
      square_nums.Add(i * i);
    }

    HashSet<int> queue = new HashSet<int>();
    queue.Add(n);

    int level = 0;
    while (queue.Count > 0) {
      level += 1;
      HashSet<int> next_queue = new HashSet<int>();

      foreach (int remainder in queue) {
        foreach (int square in square_nums) {
          if (remainder.Equals(square)) {
            return level;
          } else if (remainder < square) {
            break;
          } else {
            next_queue.Add(remainder - square);
          }
        }
      }
      queue = next_queue;
    }
    return level;
    }
}