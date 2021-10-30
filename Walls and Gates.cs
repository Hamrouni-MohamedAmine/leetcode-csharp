public class Solution {
    
    private List<int[]> DIRECTIONS = new List<int[]>{
        new int[] { 1,  0},
        new int[] {-1,  0},
        new int[] { 0,  1},
        new int[] { 0, -1}
    };
    
    public void WallsAndGates(int[][] rooms) {
        int m = rooms.Length;
        if( m == 0) return;
        int n =rooms[0].Length;
        Queue<int[]> q = new Queue<int[]>();
        for(int row=0; row < m; row++){
            for(int col=0; col < n; col++){
                if(rooms[row][col] == 0){
                    q.Enqueue(new int[]{row, col});
                }
            }
        }
        
        while(q.Count != 0){
            int[] point = q.Dequeue();
            int row =point[0];
            int col =point[1];
            foreach(int[] direction in DIRECTIONS){
                int r = row +direction[0];
                int c = col +direction[1];
                if(r < 0 || c < 0 || r >= m || c >=n || rooms[r][c] != Int32.MaxValue){
                    continue;
                }
                rooms[r][c] = rooms[row][col] + 1;
                q.Enqueue(new int[]{r,c});
            }
        }
    }
}