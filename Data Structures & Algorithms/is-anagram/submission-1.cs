public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {return false;}
        // Populate sdic
        Dictionary<char, int> sdic = new Dictionary<char, int>();
        Dictionary<char, int> tdic = new Dictionary<char, int>();
foreach (char c in s) {
    sdic[c] = sdic.GetValueOrDefault(c, 0) + 1;
}

// Populate tdic separately
foreach (char c in t) {
    tdic[c] = tdic.GetValueOrDefault(c, 0) + 1;
}

// Compare counts
foreach (var pair in sdic) {
    if (!tdic.TryGetValue(pair.Key, out int count) || count != pair.Value) {
        return false;
    }
}
return true;
    }
}
