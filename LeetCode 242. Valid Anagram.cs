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

//Another way, bad way of doing
public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<int, int> sDict = new Dictionary<int, int>();
            Dictionary<int, int> tDict = new Dictionary<int, int>();

            if(s.Length != t.Length)
                return false;

            for (int i = 0; i< s.Length; i++)
            {
                if(!sDict.ContainsKey(s[i]))
                    sDict.Add(s[i],1);
                else
                    sDict[s[i]] = sDict[s[i]]+1;
                
                if(!tDict.ContainsKey(t[i]))
                    tDict.Add(t[i],1);
                else
                    tDict[t[i]] += 1;
            }

            IEnumerator<int> keyEnumerator = sDict.Keys.GetEnumerator();

            while (keyEnumerator.MoveNext())
            {
                int key = keyEnumerator.Current;
                if(tDict.ContainsKey(key) && tDict[key] == sDict[key])
                {}
                else
                    return false;
            }

            return true;
        }
    }

