public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;

        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i]==0)
            {
                int prev = (i == 0 || flowerbed[i-1] == 0)? 0: 1;
                int next = (i == flowerbed.Length -1 ||  flowerbed[i+1] == 0)?0:1;

                if(prev == 0 && next == 0)
                {
                     flowerbed[i] = 1;
                     count++;
                }
            }
        if(count >= n)
            return true;
        }
        return false;
    }
}


/*
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int length = flowerbed.Length;

        for(int i = 0; i < length; i++)
        {
            if(flowerbed[i]==0 && (i==0 || flowerbed[i-1] == 0) && (i==length-1 || flowerbed[i+1] == 0))
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
*/

//idea: you need 1-0-1-0 etc sequence
//note: n is new flowers that can be planted
//first and last elemtents of array are edge conditions
