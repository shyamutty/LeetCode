public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if (s1.Length > s2.Length) return false;
        
        int[] s1Count = new int[26], s2Count = new int[26];
        
        for (int i = 0; i < s1.Length; i++)
            s1Count[s1[i] - 'a']++;
        
        for (int pLeft = 0, pRight = 0; pRight < s2.Length; pRight++) {
            s2Count[s2[pRight] - 'a']++;
            if (pRight - pLeft + 1 == s1.Length) {
                if (s1Count.SequenceEqual(s2Count))
                    return true;
                s2Count[s2[pLeft] - 'a']--;
                pLeft++;
            }
        }
        
        return false;
    }
}
