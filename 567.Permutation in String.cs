//Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
//In other words, return true if one of s1's permutations is the substring of s2

//Sliding window technique

class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int lengthS1 = s1.Length;
        int lengthS2 = s2.Length;

        if (lengthS1 > lengthS2)
            return false;

        int[] countmap = new int[26];

        for (int i = 0; i < lengthS1; i++)
            countmap[s1[i] - 97]++; //ascii value of a is 97


        int[] bCount = new int[26];

        for (int i = 0; i < lengthS2; i++) {
            bCount[s2[i] - 97]++;

            if (i >= (lengthS1 - 1)) { //sliding window happens here
                if (allZero(countmap, bCount))
                    return true;

                bCount[s2[i - (lengthS1 - 1)] - 97]--;
            }
        }

        return false;
    }

    private bool allZero(int[] s1, int[] s2) {
        for (int i = 0; i < 26; i++) {
            if (s1[i] != s2[i])
                return false;
        }

        return true;
    }
}
