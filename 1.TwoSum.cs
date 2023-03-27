//https://leetcode.com/problems/two-sum/
/*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 
 */


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(numDict.ContainsKey(complement))
            {
               return new int[] {numDict[complement], i};
            }
            if(!numDict.ContainsKey(nums[i])) //newly added line in case of duplicates in input
                numDict.Add(nums[i],i);
        }
        
        return new int[] {0,0};
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> map = new Dictionary<int, int>(); // initialize a dictionary to store each element and its index
    
    for (int i = 0; i < nums.Length; i++) { // iterate over each element in the input array
        int complement = target - nums[i]; // calculate the complement of the current element
        
        if (map.ContainsKey(complement)) { // if the complement is already in the dictionary
            return new int[] { map[complement], i }; // return its index and the current index as an array
        }
        
        map[nums[i]] = i; // add the current element and its index to the dictionary
    }
    
    return new int[] { -1, -1 }; // if no pair of elements add up to the target, return {-1, -1}
}


/*
This solution uses a dictionary to store each element of the input array and its index for efficient lookup. 
It then iterates over each element in the input array and calculates its complement with respect to the target value. 
If the complement is already in the dictionary, it means that a pair of elements that add up to the target has been found, 
so it returns the indices of the two elements as an array. Otherwise, it adds the current element and its index to the dictionary. 
If no pair of elements adds up to the target, it returns {-1, -1}.
*/
