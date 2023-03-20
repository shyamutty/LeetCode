public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<int, int> sDict = new Dictionary<int, int>();
            Dictionary<int, int> tDict = new Dictionary<int, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (sDict.ContainsKey(s[i]))
                    sDict[s[i]] = sDict[s[i]] + 1;
                else
                    sDict.Add(s[i], 1);

                if (tDict.ContainsKey(t[i]))
                    tDict[t[i]] = tDict[t[i]] + 1;
                else
                    tDict.Add(t[i], 1);

            }

            foreach (var key in sDict.Keys)
            {
                if (!tDict.ContainsKey(key))
                    return false;

                if (sDict[key] != tDict[key])
                    return false;
            }
           
            return true;
        }
    }
