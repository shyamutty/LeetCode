
//Using Dictionary
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        
        for(int i = 0; i< nums.Length;i++)
        {
            if(numDict.ContainsKey(nums[i]))
                return true;
            numDict.Add(nums[i], 1);
        }

        return false;
    }
}


//Using Hashset, Note: HasSet in C# is faster by 99%
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numHashSet = new HashSet<int>();
        
        for(int i = 0; i< nums.Length;i++)
        {
            if(numHashSet.Contains(nums[i]))
                return true;
            numHashSet.Add(nums[i]);
        }

        return false;
    }
}

