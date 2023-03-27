//https://leetcode.com/problems/contains-duplicate/
/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
Example 1:

Input: nums = [1,2,3,1]
Output: true

Example 2:

Input: nums = [1,2,3,4]
Output: false

Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
*/

public bool ContainsDuplicate(int[] nums) {
    HashSet<int> set = new HashSet<int>(); // initialize a hash set to store unique elements
    
    foreach (int num in nums) { // iterate over each element in the input array
        if (set.Contains(num)) { // if the element is already in the set, return true
            return true;
        }
        
        set.Add(num); // otherwise, add the element to the set
    }
    
    return false; // if no duplicate is found, return false
}

/*
This solution uses a hash set to store unique elements in the input array. 
It iterates over each element in the input array and checks if it is already in the set. 
If the element is already in the set, it means that there is a duplicate, so it returns true. Otherwise, it adds the element to the set. 
If no duplicate is found, it returns false.
*/

