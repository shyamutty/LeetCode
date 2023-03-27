//https://leetcode.com/problems/product-of-array-except-self/
/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
You must write an algorithm that runs in O(n) time and without using the division operation.

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
*/


public int[] ProductExceptSelf(int[] nums) {
    int n = nums.Length; // get the length of the input array
    
    int[] output = new int[n]; // initialize an output array to store the product of all elements except the current element
    
    output[0] = 1; // initialize the first element in the output array to 1
    
    for (int i = 1; i < n; i++) { // calculate the product of all elements to the left of the current element and store it in the output array
        output[i] = output[i - 1] * nums[i - 1];
    }
    
    int rightProduct = 1; // initialize the product of all elements to the right of the current element to 1
    
    for (int i = n - 1; i >= 0; i--) { // calculate the product of all elements to the right of the current element and 
                                       //multiply it with the product of all elements to the left of the current element in the output array
        output[i] *= rightProduct;
        rightProduct *= nums[i];
    }
    
    return output; // return the output array
}

//make two passes, first in-order, second in-reverse, to compute products
//https://www.youtube.com/watch?v=bNvIQI2wAjk
/*
This solution uses two passes to calculate the product of all elements except the current element in the input array. 
In the first pass, it calculates the product of all elements to the left of the current element and stores it in the output array. 
In the second pass, it calculates the product of all elements to the right of the current element and 
multiplies it with the product of all elements to the left of the current element in the output array. 
It stores the final product in the output array and returns it.
*/


