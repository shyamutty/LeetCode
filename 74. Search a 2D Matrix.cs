/*
https://leetcode.com/problems/search-a-2d-matrix/

https://www.geeksforgeeks.org/search-in-a-sorted-2d-matrix-stored-in-row-major-order/


You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
Output: true

Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
Output: false

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 100
-104 <= matrix[i][j], target <= 104

Approach: The idea is to use divide and conquer approach to solve this problem. 

First apply Binary Search to find the particular row i.e ‘K’ lies between the first and the last element of that row.
Then apply simple binary search on that row to find whether ‘K’ is present in that row or not.

*/


public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix.Length == 0)
            return false;
        
        int rows = matrix.Length, columns = matrix[0].Length;
        int left = 0, right = rows * columns - 1;
        
        while(left <= right) {
            int middle = left + (right - left) / 2;
            int middlePoint = matrix[middle / columns][middle % columns];
            
            if(target == middlePoint) {
                return true;
            } else if(target < middlePoint) {
                right = middle - 1;
            } else if(target > middlePoint) {
                left = middle + 1;
            }
        }
        
        return false;
    }

 
 
