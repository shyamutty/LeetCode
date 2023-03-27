//https://leetcode.com/problems/roman-to-integer/
/*
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. 
The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.


Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.

Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
*/

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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public int RomanToInt(string s) {
    Dictionary<char, int> map = new Dictionary<char, int> { // initialize a dictionary to map each Roman numeral to its integer value
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    
    int result = 0; // initialize the result to 0
    
    for (int i = 0; i < s.Length; i++) { // iterate over each character in the input string
        int value = map[s[i]]; // look up the integer value of the current Roman numeral
        
        if (i < s.Length - 1 && value < map[s[i + 1]]) { // if the next Roman numeral has a higher value
            result -= value; // subtract the current value from the result
        } else {
            result += value; // otherwise, add the current value to the result
        }
    }
    
    return result; // return the result
}

/*
This solution uses a dictionary to map each Roman numeral to its integer value. 
It then iterates over each character in the input string and looks up its integer value in the dictionary. 
If the next Roman numeral has a higher value, it subtracts the current value from the result. 
Otherwise, it adds the current value to the result. The final result is returned at the end.
*/
