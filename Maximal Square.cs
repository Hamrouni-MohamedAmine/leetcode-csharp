public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int result=0;
        int rows = matrix.Length;
         if(rows == 0)
            return 0;
        int cols = matrix[0].Length;
       
        
       int[][] dp = new int[rows +1][];
               dp[0] = new int[cols +1];
        for(int i=1; i<= rows;i++){
            dp[i] = new int[cols +1];
            for(int j=1; j<= cols;j++){
                dp[i][j]=0;
                if(matrix[i-1][j-1]=='1'){
                    dp[i][j] = 1 +Math.Min(dp[i - 1][j],Math.Min(dp[i][j - 1],dp[i - 1][j - 1]));
                    if(result <dp[i][j])
                        result = dp[i][j];
                }
            }
        }
        return result * result;
    }
}