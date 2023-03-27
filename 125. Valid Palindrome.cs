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

