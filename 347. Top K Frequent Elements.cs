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
