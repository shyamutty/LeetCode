public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int n in nums)
        {
            // check if it's the start of a sequence
            if (!numSet.Contains(n - 1))
            {
                int length = 1;
                while (numSet.Contains(n + length))
                {
                    length++;
                }
                longest = Math.Max(length, longest);
            }
        }
        return longest;
    }

}


//https://www.youtube.com/watch?v=P6RZZMu_maU
