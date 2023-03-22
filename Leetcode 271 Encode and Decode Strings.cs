public string Encode(string[] strs)
{
    string res = "";
    foreach (string s in strs)
    {
        res += s.Length.ToString() + "#" + s;
    }
    return res;
}

public string[] Decode(string str)
{
    List<string> res = new List<string>();
    int i = 0;
    while (i < str.Length)
    {
        int j = i + 1;
        while (str[j] != '#')
        {
            j++;
        }
        int length = int.Parse(str.Substring(i, j - i));
        res.Add(str.Substring(j + 1, length));
        i = j + 1 + length;
    }
    return res.ToArray();
}


//hi how are you
//2#hi3#how3#are3#you
