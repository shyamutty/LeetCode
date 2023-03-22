public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];

        int prefix = 1;
        int postfix = 1;

        for(int i = 0; i< n; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }
        for(int i = n-1; i>=0; i--)
        {
            res[i]*= postfix;
            postfix*=nums[i];
        }

        return res;

    }
}

//make two passes, first in-order, second in-reverse, to compute products
//https://www.youtube.com/watch?v=bNvIQI2wAjk
