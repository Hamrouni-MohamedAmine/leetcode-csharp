public class Solution {
    public int OpenLock(string[] deadends, string target) {
      var dead = new HashSet<string>(deadends);
      Queue<string> q = new Queue<string>();
        q.Enqueue("0000");
        q.Enqueue(null);
        
        var seen = new HashSet<string>(deadends);
        seen.Add("0000");
        int depth = 0;
        
        while(q.Count != 0){
            string node = q.Dequeue();
            if( node == null){
                depth++;
                if(q.Count != 0 && q.Peek() != null){
                    q.Enqueue(null);
                }
            }else if (node == target){
                return depth;
            }else if(!dead.Contains(node)){
                  for (int i = 0; i < 4; ++i) {
                       for (int d = -1; d <= 1; d += 2) {
                           int y = (int.Parse(node[i].ToString()) + d +10) % 10;
                           string nei = node.Substring(0,i) + y + node.Substring(i+1);
                           if(! seen.Contains(nei)){
                               seen.Add(nei);
                               q.Enqueue(nei);
                           }
                       }
                  }
            }
        }
        return -1;
    }
}