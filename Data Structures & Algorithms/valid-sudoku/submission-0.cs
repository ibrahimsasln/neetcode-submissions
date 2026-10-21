public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        HashSet<char>[] square = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            square[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            HashSet<char> row = new();
            HashSet<char> col = new();

            for (int j = 0; j < 9; j++)
            {
                int squareIndex = (i / 3) * 3 + (j / 3);

                if (board[i][j] != '.' && !row.Add(board[i][j])) return false;
                if (board[j][i] != '.' && !col.Add(board[j][i])) return false;
                if (board[i][j] != '.' && !square[squareIndex].Add(board[i][j])) return false;
            }
        }
        return true;
    }
}
