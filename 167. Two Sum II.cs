//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/*
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, 
find two numbers such that they add up to a specific target number. 
Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
The tests are generated such that there is exactly one solution. You may not use the same element twice.
Your solution must use only constant extra space.

Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].

Example 2:

Input: numbers = [2,3,4], target = 6
Output: [1,3]
Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].

*/

public int[] TwoSum(int[] numbers, int target) {
    int left = 0; // initialize left pointer to index 0
    int right = numbers.Length - 1; // initialize right pointer to index numbers.Length - 1
        
    while (left < right) { // while left pointer is less than right pointer
        int sum = numbers[left] + numbers[right]; // calculate sum of values at left and right pointers
            
        if (sum == target) { // if sum equals target
            return new int[] { left + 1, right + 1 }; // return indices (1-based) of left and right pointers as array
        }
        else if (sum < target) { // if sum is less than target
            left++; // move left pointer one index to the right
        }
        else { // if sum is greater than target
            right--; // move right pointer one index to the left
        }
    }
        
    return new int[] {-1, -1}; // if no indices are found, return {-1, -1}
}

/*
This solution uses a two-pointer approach to find the indices of two numbers in the given array that add up to the target value. 
The pointers start at opposite ends of the array and move towards each other until the target value is found or the pointers cross each other.
*/
