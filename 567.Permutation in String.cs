/*
Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
In other words, return true if one of s1's permutations is the substring of s2.

Example 1:

Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: s2 contains one permutation of s1 ("ba").

Example 2:

Input: s1 = "ab", s2 = "eidboaoo"
Output: false

Constraints:

1 <= s1.length, s2.length <= 104
s1 and s2 consist of lowercase English letters.
*/

//Sliding window technique

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // Create an array to count the frequency of each character in s1.
        int[] charCount = new int[26];
        foreach (char c in s1) {
            charCount[c - 'a']++;
        }
        
        int left = 0;
        int right = 0;
        int count = s1.Length;
        // Iterate through s2 using a sliding window of size s1.Length.
        while (right < s2.Length) {
            // If the character at the right edge of the window is in s1,
            // decrement the character count and the total count of remaining
            // characters in s1.
            if (charCount[s2[right] - 'a']-- >= 1) {
                count--;
            }
            right++;
            
            // If all characters in s1 have been found in s2, return true.
            if (count == 0) {
                return true;
            }
            
            // If the window is larger than s1.Length, move the left edge of
            // the window forward and increment the character count and total
            // count of remaining characters in s1 if necessary.
            if (right - left == s1.Length) {
                if (charCount[s2[left] - 'a']++ >= 0) {
                    count++;
                }
                left++;
            }
        }
        
        // If we've checked all windows of size s1.Length and haven't found
        // a permutation of s1, return false.
        return false;
    }
}

/*
We create an array to count the frequency of each character in s1.
We use a sliding window technique to iterate through s2.
At each iteration, we check if the character at the right edge of the window is in s1.
If it is, we decrement the count of that character in s1 and the total count of remaining characters in s1.
If we've found all characters in s1, we return true.
If the window is larger than s1, we move the left edge of the window forward and increment the count of the character that was removed from the window.
If we've checked all windows of size s1 and haven't found a permutation of s1, we return false.
*/

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }
        
        // Create a dictionary to store the frequency of characters in s1.
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in s1) {
            if (!charCount.ContainsKey(c)) {
                charCount[c] = 0;
            }
            charCount[c]++;
        }
        
        // Iterate through s2 using a sliding window of size s1.Length.
        for (int i = 0; i < s2.Length - s1.Length + 1; i++) {
            Dictionary<char, int> windowCount = new Dictionary<char, int>();
            for (int j = i; j < i + s1.Length; j++) {
                char c = s2[j];
                if (!windowCount.ContainsKey(c)) {
                    windowCount[c] = 0;
                }
                windowCount[c]++;
            }
            
            // Compare the frequency of characters in the window and s1.
            bool isPermutation = true;
            foreach (char c in charCount.Keys) {
                if (!windowCount.ContainsKey(c) || windowCount[c] != charCount[c]) {
                    isPermutation = false;
                    break;
                }
            }
            if (isPermutation) {
                return true;
            }
        }
        
        return false;
    }
}

/*
A good approach is to use a sliding window technique to compare s1 and all substrings of length s1.Length in s2. 
We create a dictionary to store the frequency of characters in s1, and then iterate through s2 using a sliding window of size s1.Length. 
At each iteration, we decrement the frequency of the character at the left edge of the window and increment the frequency 
of the character at the right edge of the window. If the frequency of all characters in s1 is zero, we return true.
*/


