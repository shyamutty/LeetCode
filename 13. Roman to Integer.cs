public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> numDictionary = new Dictionary<char,int>();
        numDictionary.Add('I',1);
        numDictionary.Add('V',5);
        numDictionary.Add('X',10);
        numDictionary.Add('L',50);
        numDictionary.Add('C',100);
        numDictionary.Add('D',500);
        numDictionary.Add('M',1000);
        
        int result = numDictionary[s[s.Length-1]];
        for(int i = s.Length - 2; i>= 0; i--)
        {
            if(numDictionary[s[i]] < numDictionary[s[i+1]])
                result -= numDictionary[s[i]];
            else
                result += numDictionary[s[i]];
        }
        return result;
    }
}
