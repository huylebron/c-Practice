string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0) return "";

    string prefix = strs[0];

    for (int i = 1; i < strs.Length; i++)
    {
        while (!strs[i].StartsWith(prefix))
        {
            prefix = prefix[..^1];

            if (prefix == "") return "";
        }
    }

    return prefix;
}

Console.WriteLine(LongestCommonPrefix(new[] { "dog", "racecar", "car" }));    // Output: ""