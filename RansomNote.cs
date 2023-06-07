// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

// Each letter in magazine can only be used once in ransomNote.

// Constraints:

// 1 <= ransomNote.length, magazine.length <= 105
// ransomNote and magazine consist of lowercase English letters.

bool CanConstruct(string ransomNote, string magazine)
{
    var list = new List<char>(magazine);

    for (int i = 0; i < ransomNote.Length; i++)
    {
        char c = ransomNote[i];
        if (!list.Remove(c))
        {
            return false;
        }
    }

    return true;
}