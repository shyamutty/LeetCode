//https://leetcode.com/problems/valid-palindrome/
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, 
it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
*/

public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        while (l < r) {
            while (l < r && !IsAlphaNum(s[l])) {
                l++;
            }
            while (l < r && !IsAlphaNum(s[r])) {
                r--;
            }
            if (char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

    public bool IsAlphaNum(char c) {
        return (char.IsLetterOrDigit(c));
    }
}


//https://www.youtube.com/watch?v=jJXJ16kPFWg
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public bool IsPalindrome(string s) {
    s = s.ToLower(); // convert string to lowercase
    
    int left = 0; // initialize left pointer to index 0
    int right = s.Length - 1; // initialize right pointer to last index of string
    
    while (left < right) { // while left pointer is less than right pointer
        while (left < right && !char.IsLetterOrDigit(s[left])) { // skip non-alphanumeric characters from left pointer
            left++;
        }
        
        while (left < right && !char.IsLetterOrDigit(s[right])) { // skip non-alphanumeric characters from right pointer
            right--;
        }
        
        if (s[left] != s[right]) { // if characters at left and right pointers don't match
            return false; // not a palindrome
        }
        
        left++; // move left pointer one index to the right
        right--; // move right pointer one index to the left
    }
    
    return true; // if all characters match, it's a palindrome
}

/*
This solution uses a two-pointer approach to check whether a given string is a palindrome. 
The pointers start at opposite ends of the string and move towards each other until they meet in the middle or one pointer passes the other. 
Non-alphanumeric characters are skipped over during the comparison.

Note that we convert the string to lowercase before performing the comparison to make it case-insensitive.
*/
