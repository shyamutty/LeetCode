//https://leetcode.com/problems/longest-consecutive-sequence/description/
/*
Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9

*/

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
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
public int LongestConsecutive(int[] nums) {
    HashSet<int> set = new HashSet<int>(nums); // add all elements of nums to a hash set for efficient lookup
    
    int longestStreak = 0; // initialize longest streak to 0
    
    foreach (int num in set) { // iterate over each element in the set
        if (!set.Contains(num - 1)) { // if the previous element is not in the set
            int currentNum = num; // initialize current number to current element
            int currentStreak = 1; // initialize current streak to 1
            
            while (set.Contains(currentNum + 1)) { // while the next element is in the set
                currentNum++; // increment current number
                currentStreak++; // increment current streak
            }
            
            longestStreak = Math.Max(longestStreak, currentStreak); // update longest streak if current streak is greater
        }
    }
    
    return longestStreak; // return longest streak
}


/*
This solution uses a hash set to store the elements of the input array for efficient lookup. 
It then iterates over each element in the set and checks whether the previous element is in the set. 
If not, it starts a streak by initializing a current number and streak to the current element and 1, respectively. 
It then continues to increment the current number and streak as long as the next element is in the set. 
The longest streak is updated with the maximum of the current streak and the previous longest streak. 
The final result is the longest streak.
*/
