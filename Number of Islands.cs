public class Solution {
    public int NumIslands(char[][] grid) {
        int numberOfIslands = 0;
        for(int i=0; i < grid.Length; i++){
            for(int j = 0; j < grid[0].Length; j++){
                if(grid[i][j] == '1'){
                    DFS(i,j,grid);
                    numberOfIslands++;
                }
            }
        }
        return numberOfIslands;
    }
    
    public void DFS(int i, int j, char[][] grid){
        if(grid[i][j] == '1'){
       
        grid[i][j] = 'v';
        if(i > 0){
            DFS(i-1,j,grid);
        }
        if(j > 0){
            DFS(i,j-1,grid);
        }
        if(i < grid.Length -1){
            DFS(i+1,j,grid);
        }
        if(j < grid[0].Length -1){
            DFS(i,j+1, grid);
        }
             }
    }
}