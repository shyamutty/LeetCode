using System.Collections.Generic;

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

//Another way

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


