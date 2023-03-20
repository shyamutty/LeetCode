public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int length = flowerbed.Length;

        for(int i = 0; i < length; i++)
        {
            if(flowerbed[i]==0 && (i<0 || flowerbed[i-1] == 0) && (i==length-1 || flowerbed[i+1] == 0))
            {
                flowerbed[i] = 1;
                n -= 1;
                if(n == 0)
                    return true;
            }
        }
        return n<=0;
    }
}
