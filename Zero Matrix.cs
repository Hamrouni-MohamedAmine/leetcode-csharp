public static void zeroMatrix (int[][] matrix) {
    var length = matrix.Length;
    bool[] RowsHasZero = new bool[length];
    bool[] ColumnsHasZero = new bool[length];

    for (int i = 0; i < length; i++) {
        for (int j = 0; j < length; j++) {
            if (matrix[i][j] == 0) {
                RowsHasZero[i] = true;
                ColumnsHasZero[j] = true;
            }

        }
    }

    for (int r = 0; r < length; r++) {
        if (RowsHasZero[r]) setRowsToZero (matrix, r);
    }

    for (int c = 0; c < length; c++) {
        if (ColumnsHasZero[c]) setColumnsToZero (matrix, c);
    }
}

public static void setRowsToZero (int[][] matrix, int r) {
    for (int i = 0; i < matrix.Length; i++) {
        matrix[r][i] = 0;
    }
}

public static void setColumnsToZero (int[][] matrix, int c) {
    for (int i = 0; i < matrix.Length; i++) {
        matrix[i][c] = 0;
    }
}