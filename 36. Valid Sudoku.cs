//https://leetcode.com/problems/valid-sudoku/
/*
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.

Example 1:

Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true

Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. 
Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 
Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.
*/


public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var squares = new HashSet<char>[9];
        
        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            squares[i] = new HashSet<char>();
        }
        
        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                if (board[r][c] == '.') {
                    continue;
                }
                
                if (!rows[r].Add(board[r][c]) ||
                    !cols[c].Add(board[r][c]) ||
                    !squares[(r / 3) * 3 + c / 3].Add(board[r][c])) {
                    return false;
                }
            }
        }
        
        return true;
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        
        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        
        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                char val = board[row][col];
                if (val == '.') continue;
                if (!rows[row].Add(val) || !cols[col].Add(val) || !boxes[3 * (row / 3) + col / 3].Add(val)) {
                    return false;
                }
            }
        }
        
        return true;
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public bool IsValidSudoku(char[][] board) {
    // Check each row
    for (int i = 0; i < 9; i++) {
        HashSet<char> row = new HashSet<char>();
        for (int j = 0; j < 9; j++) {
            if (board[i][j] != '.') {
                if (row.Contains(board[i][j])) {
                    return false;
                } else {
                    row.Add(board[i][j]);
                }
            }
        }
    }

    // Check each column
    for (int j = 0; j < 9; j++) {
        HashSet<char> column = new HashSet<char>();
        for (int i = 0; i < 9; i++) {
            if (board[i][j] != '.') {
                if (column.Contains(board[i][j])) {
                    return false;
                } else {
                    column.Add(board[i][j]);
                }
            }
        }
    }

    // Check each 3x3 sub-grid
    for (int i = 0; i < 9; i += 3) {
        for (int j = 0; j < 9; j += 3) {
            HashSet<char> subgrid = new HashSet<char>();
            for (int k = 0; k < 3; k++) {
                for (int l = 0; l < 3; l++) {
                    int row = i + k;
                    int col = j + l;
                    if (board[row][col] != '.') {
                        if (subgrid.Contains(board[row][col])) {
                            return false;
                        } else {
                            subgrid.Add(board[row][col]);
                        }
                    }
                }
            }
        }
    }

    // All checks passed
    return true;
}

/*
We iterate through each row of the board and check if it's a valid Sudoku row. 
To do this, we use a HashSet to keep track of the numbers we've seen in the row. 
If we see a number that's already in the HashSet, we know the row is invalid and we return false.

We iterate through each column of the board and check if it's a valid Sudoku column. We use a similar approach to checking the rows.

We iterate through each 3x3 sub-grid of the board and check if it's a valid Sudoku sub-grid. 
We use a nested loop to iterate through each cell in the sub-grid, and use a HashSet to keep track of the numbers we've seen. 
We calculate the row and column index of each cell based on the current sub-grid's position and the current cell's position within the sub-grid.

If we find any invalid rows, columns, or sub-grids, we return false. Otherwise, we return true.
*/

public bool IsValidSudoku(char[][] board) {
    // Define a hashset to store the visited cells
    HashSet<string> visited = new HashSet<string>();

    // Loop through each cell in the board
    for (int i = 0; i < 9; i++) {
        for (int j = 0; j < 9; j++) {
            // If the current cell is not empty
            if (board[i][j] != '.') {
                // Define a string to represent the current cell's position
                string rowStr = i.ToString();
                string colStr = j.ToString();
                string boxStr = (i / 3).ToString() + (j / 3).ToString();

                // Check if the current cell's value has already been visited
                if (visited.Contains(rowStr + board[i][j]) ||
                    visited.Contains(colStr + board[i][j]) ||
                    visited.Contains(boxStr + board[i][j])) {
                    return false;
                } else {
                    // If the current cell's value has not been visited, add it to the visited hashset
                    visited.Add(rowStr + board[i][j]);
                    visited.Add(colStr + board[i][j]);
                    visited.Add(boxStr + board[i][j]);
                }
            }
        }
    }

    // All checks passed, return true
    return true;
}

/*
We define a HashSet called visited to keep track of the cells we've visited.

We loop through each cell in the board and check if it's valid. To do this, we check if the cell is not empty (i.e., it contains a number).

If the current cell is not empty, we define three strings that represent the current cell's position: rowStr 
(the row index of the current cell), colStr (the column index of the current cell), and boxStr (the index of the 3x3 sub-box that contains the current cell).

We then check if the current cell's value has already been visited. To do this, we concatenate the position string and the cell value, 
and check if the resulting string is already in the visited hashset. If the value has already been visited in the row, column, or sub-box,
we know the board is invalid and we return false.

If the current cell's value has not been visited, we add it to the visited hashset by concatenating the position string and the cell value, 
and adding the resulting string to the hashset.

Once we've checked all cells in the board, if we haven't returned false, we know the board is valid and we return true.

This solution is efficient because it only loops through each cell in the board once, and uses a hashset to check for duplicate values in constant time

*/

