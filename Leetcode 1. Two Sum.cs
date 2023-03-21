public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> prevDict = new Dictionary<int,int>();

        for(int i = 0; i< nums.Length; i++)
        {
            int difference = target - nums[i];
            if(prevDict.ContainsKey(difference))
                return new int[] {prevDict[difference], i};

            if(!prevDict.ContainsKey(nums[i]))
                prevDict.Add(nums[i], i);
        }

         return new int[] {0,0};
    }
}
