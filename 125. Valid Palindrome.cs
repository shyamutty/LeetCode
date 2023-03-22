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

