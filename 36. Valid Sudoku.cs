public class Solution {
    public bool IsValidSudoku(char[][] board) {
    Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
    Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
    Dictionary<int, HashSet<char>> squares = new Dictionary<int, HashSet<char>>(); // key: r/3, c/3

    for (int r = 0; r < 9; r++) {
        for (int c = 0; c < 9; c++) {
            if (board[r][c] == '.') {
                continue;
            }

            if (rows.ContainsKey(r) && rows[r].Contains(board[r][c]) ||
                cols.ContainsKey(c) && cols[c].Contains(board[r][c]) ||
                squares.ContainsKey((r / 3) * 3 + c / 3) && squares[(r / 3) * 3 + c / 3].Contains(board[r][c])) {
                return false;
            }

            if (!cols.ContainsKey(c)) {
                cols[c] = new HashSet<char>();
            }
            cols[c].Add(board[r][c]);

            if (!rows.ContainsKey(r)) {
                rows[r] = new HashSet<char>();
            }
            rows[r].Add(board[r][c]);

            if (!squares.ContainsKey((r / 3) * 3 + c / 3)) {
                squares[(r / 3) * 3 + c / 3] = new HashSet<char>();
            }
            squares[(r / 3) * 3 + c / 3].Add(board[r][c]);
        }
    }
    return true;
}

}


/*
The expression squares.ContainsKey((r / 3) * 3 + c / 3) checks whether the squares dictionary contains a key corresponding to the 3x3 subgrid
(or "square") that contains the cell at row r and column c. 
The subgrid is determined by dividing both the row and column indices by 3, which gives a number between 0 and 2. 
This number is then multiplied by 3 and added to the other number, resulting in a number between 0 and 8 that uniquely identifies the subgrid. 
For example, if r = 4 and c = 7, the subgrid is identified by the key (4 / 3) * 3 + 7 / 3 = 3 * 2 + 2 = 8.
If the squares dictionary does contain the key for the subgrid, the expression squares[(r / 3) * 3 + c / 3].Contains(board[r][c]) 
checks whether the set associated with that key already contains the number board[r][c]. If it does, it means that the same number has already 
been seen in the same subgrid, so the Sudoku board is invalid and the function returns false.

*.
