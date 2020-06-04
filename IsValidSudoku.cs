 public static bool IsValidSudoku(char[][] board)
        {
            List<string> chars = new List<string>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    char current = board[i][j];
                    if(current != '.')
                    {
                        if (chars.Find(x =>
                                 x.Equals(current + " found in row " + i) ||
                                 x.Equals(current + " found in column " + j) ||
                                x.Equals(current + " found in sub box i:" + i / 3 + "- j:" + j / 3)) != null)
                            return false;
                        chars.Add(current + " found in row " + i);
                        chars.Add(current + " found in column " + j);
                        chars.Add(current + " found in sub box i:" + i / 3 + "- j:" + j / 3);
                    }
                 
                }
            }
            return true;
        }