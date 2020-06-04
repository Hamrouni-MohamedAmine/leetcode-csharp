 public static void Rotate (int[][] matrix) {
     var length = matrix.Length;
     for (int i = 0; i < length; i++) {
         for (int j = i; j < length; j++) {
             var temp = matrix[i][j];
             matrix[i][j] = matrix[j][i];
             matrix[j][i] = temp;
         }
     }

     for (int i = 0; i < length; i++) {
         for (int j = 0; j < length / 2; j++) {
             var temp = matrix[i][j];
             matrix[i][j] = matrix[i][(length - 1) - j];
             matrix[i][(length - 1) - j] = temp;
         }
     }

 }