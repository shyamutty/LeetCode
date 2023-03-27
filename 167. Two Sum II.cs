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
