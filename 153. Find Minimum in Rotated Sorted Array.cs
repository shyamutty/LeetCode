//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
/*
153. Find Minimum in Rotated Sorted Array
Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

[4,5,6,7,0,1,2] if it was rotated 4 times.
[0,1,2,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

Given the sorted rotated array nums of unique elements, return the minimum element of this array.

You must write an algorithm that runs in O(log n) time.
 
Example 1:

Input: nums = [3,4,5,1,2]
Output: 1
Explanation: The original array was [1,2,3,4,5] rotated 3 times.

Example 2:

Input: nums = [4,5,6,7,0,1,2]
Output: 0
Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.

Example 3:

Input: nums = [11,13,15,17]
Output: 11
Explanation: The original array was [11,13,15,17] and it was rotated 4 times. 
 
Constraints:

n == nums.length
1 <= n <= 5000
-5000 <= nums[i] <= 5000
All the integers of nums are unique.
nums is sorted and rotated between 1 and n times.
*/

public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right]) { // if the middle element is greater than the rightmost element
                left = mid + 1; // the minimum element must be to the right of mid
            } else { // if the middle element is smaller than the rightmost element
                right = mid; // the minimum element must be to the left of or at mid
            }
        }
        return nums[left]; // return the element at the left index (which is the minimum element)
    }
}

/*
Initialize two variables, left and right, to represent the indices of the leftmost and rightmost elements in the array, respectively.
Use a while loop to continue searching until the left and right variables converge to the minimum element.
Inside the loop, calculate the index of the middle element using the formula mid = left + (right - left) / 2.
Check if the middle element is greater than the rightmost element. If so, this means the minimum element must be to the right of the middle element. 
Update left to be mid + 1.
If the middle element is smaller than the rightmost element, this means the minimum element must be to the left of or at the middle element. 
Update right to be mid.
After the loop finishes, the left index will be pointing to the minimum element in the array. Return the element at that index.
Overall, this solution has a time complexity of O(log n) since it uses binary search, and a space complexity of O(1) since it only uses a few constant variables.
*/
