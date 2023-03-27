//https://leetcode.com/problems/top-k-frequent-elements/
/*
Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]

Example 2:

Input: nums = [1], k = 1
Output: [1]

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
k is in the range [1, the number of unique elements in the array].
It is guaranteed that the answer is unique.

Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
*/


public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> countDict = new Dictionary<int, int>();
        List<int>[] freqList = new List<int>[nums.Length + 1];

        foreach (int n in nums) {
            if (!countDict.ContainsKey(n)) {
                countDict[n] = 0;
            }
            countDict[n]++;
        }

        //input: nums = [1,1,1,2,2,3], k = 2
        //count = [1,3], [2,2], [3,1] // [num, frequency]
        //bucket sort

        foreach (KeyValuePair<int, int> pair in countDict) {
            int num = pair.Key;
            int frequency = pair.Value;

            if (freqList[frequency] == null) {
                freqList[frequency] = new List<int>();
            }
            freqList[frequency].Add(num);
            //This creates a new List<int> object and assigns it to the ith element of the freqList array. 
            //Now you can add integers to each List<int> object in the array
            //freqList[3].Add(1); 
            //freqList[2].Add(2); 
            //freqList[1].Add(3); 
        }

        List<int> res = new List<int>();
        for (int i = freqList.Length - 1; i >= 0; i--) {
            if (freqList[i] != null) {
                foreach (int num in freqList[i]) {
                    res.Add(num);
                    if (res.Count == k) {
                        return res.ToArray();
                    }
                }
            }
        }

        return res.ToArray();
    }
}

//https://www.youtube.com/watch?v=YPTqKIgVk-k
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public int[] TopKFrequent(int[] nums, int k) {
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
    List<int>[] bucket = new List<int>[nums.Length + 1];

    // Count frequency of each number using a dictionary
    foreach (int num in nums) {
        if (!frequencyMap.ContainsKey(num)) {
            frequencyMap[num] = 0;
        }
        frequencyMap[num]++;
    }

    // Put numbers into buckets based on their frequency
    foreach (int num in frequencyMap.Keys) {
        int frequency = frequencyMap[num];
        if (bucket[frequency] == null) {
            bucket[frequency] = new List<int>();
        }
        bucket[frequency].Add(num);
    }

    // Extract top k frequent elements from buckets
    List<int> result = new List<int>();
    for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--) {
        if (bucket[i] != null) {
            result.AddRange(bucket[i]);
        }
    }

    return result.ToArray();
}

/*
We first create a dictionary called frequencyMap to count the frequency of each number in the input array. 
The keys in the dictionary are the numbers in the input array, and the values are their corresponding frequencies.

We then create an array of lists called bucket, where each index in the array represents a frequency count. 
We'll use these buckets to group numbers by their frequency.

We loop through the frequencyMap dictionary and put each number into its corresponding bucket based on its frequency.

We then extract the top k frequent elements from the buckets by iterating through the bucket array from right to left and 
adding the elements from each non-empty bucket to the result list. We stop when the size of result is equal to k.

Finally, we convert the result list to an array and return it.
*/


