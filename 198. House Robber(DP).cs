public class Solution {
    public int Rob(int[] nums) {
        int rob1 = 0, rob2 = 0;

        for(int i = 0; i< nums.Length; i++)
        {
            var temp = Math.Max(nums[i] + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;
    }
}

//https://www.youtube.com/watch?v=73r3KWiEvyk
