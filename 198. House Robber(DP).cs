//https://leetcode.com/problems/house-robber/
/*
You are a professional robber planning to rob houses along a street. 
Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses 
have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

Example 1:

Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.

Example 2:

Input: nums = [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
Total amount you can rob = 2 + 9 + 1 = 12.

Constraints:

1 <= nums.length <= 100
0 <= nums[i] <= 400
*/

public int Rob(int[] nums) {
    if (nums == null || nums.Length == 0) { // if the input array is null or empty, return 0
        return 0;
    }
    
    int prevMax = 0; // initialize the maximum amount that can be robbed from the previous house to 0
    int currMax = 0; // initialize the maximum amount that can be robbed from the current house to 0
    
    for (int i = 0; i < nums.Length; i++) { // iterate over each house in the input array
        int temp = currMax; // temporarily store the current maximum amount
        
        currMax = Math.Max(prevMax + nums[i], currMax); // update the current maximum amount based on the maximum of the previous maximum amount plus the current house and the current maximum amount
        prevMax = temp; // update the previous maximum amount to the previous current maximum amount
    }
    
    return currMax; // return the final current maximum amount
}
//https://www.youtube.com/watch?v=73r3KWiEvyk
/*
This solution uses dynamic programming to calculate the maximum amount that can be robbed without robbing adjacent houses. 
It initializes the maximum amount that can be robbed from the previous house and the current house to 0. 
It then iterates over each house in the input array and updates the current maximum amount based on the 
maximum of the previous maximum amount plus the current house and the current maximum amount. 
It also updates the previous maximum amount to the previous current maximum amount. 
Finally, it returns the final current maximum amount.
*/





