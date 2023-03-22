public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
       var res = new Dictionary<string, List<string>>();
        foreach (var s in strs) {
            var count = new int[26];
            foreach (var c in s) {
                count[c - 'a']++;
            }
            var key = string.Join(",", count);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<IList<string>>();
    }
}

//https://www.youtube.com/watch?v=vzdNOK2oB2E
//Easy Way

public IList<IList<string>> GroupAnagrams(string[] strs) {
    var groups = new Dictionary<string, List<string>>();
    foreach (string s in strs) {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        string sorted = new string(chars);
        if (!groups.ContainsKey(sorted)) {
            groups[sorted] = new List<string>();
        }
        groups[sorted].Add(s);
    }
    return groups.Values.ToList();
}
