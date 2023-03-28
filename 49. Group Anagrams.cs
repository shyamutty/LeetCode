//https://leetcode.com/problems/group-anagrams/
/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Example 2:

Input: strs = [""]
Output: [[""]]

Example 3:

Input: strs = ["a"]
Output: [["a"]]

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
*/

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
//Easy Way using Array.Sort
/////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // create a dictionary to store the anagrams
        var dict = new Dictionary<string, List<string>>();
        
        // loop through each string in the input array
        foreach (string str in strs) {
            // create an array to store the frequency of each character
            int[] freq = new int[26];
            
            // count the frequency of each character in the string
            foreach (char c in str) {
                freq[c - 'a']++;
            }
            
            // create a string key from the frequency array
            string key = string.Join(",", freq);
            
            // if the key is not already in the dictionary, add it
            if (!dict.ContainsKey(key)) {
                dict.Add(key, new List<string>());
            }
            
            // add the original string to the list of anagrams
            dict[key].Add(str);
        }
        
        // convert the dictionary values to a list and return it
        return dict.Values.ToList();
    }
}


/*
We create a dictionary called dict to store the anagrams.
We loop through each string in the strs array using a foreach loop.
Inside the loop, we create an array called freq of length 26 to store the frequency of each character in the current string str.
We count the frequency of each character in str by looping through each character c in str and incrementing the corresponding frequency in freq using freq[c - 'a']++;.
We create a new string key from the frequency array freq using string.Join(",", freq);.
We check if the key string is not already in the dict dictionary using if (!dict.ContainsKey(key)). If it's not, we add it to the dictionary with an empty list using dict.Add(key, new List<string>());.
We add the original string str to the list of anagrams corresponding to the key in the dictionary using dict[key].Add(str);.
After the loop, we convert the dictionary values to a list using dict.Values.ToList() and return it.
*/

/*
freq[0] = 2 // count of 'a'
freq[1] = 1 // count of 'b'
freq[2] = 0 // count of 'c'
...
freq[25] = 0 // count of 'z'


Now we need a way to convert this frequency array to a unique string that can be used as a key in the dictionary. 
One way to do this is to convert the freq array to a comma-separated string. 
For example, the freq array above would be converted to the string "2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0".

This string representation of the freq array serves as a unique identifier for anagrams. 
For example, if two strings have the same frequency array, then they are anagrams of each other. 
We can use this string as a key in the dictionary and store the original strings that have the same frequency array as the value.

*/

