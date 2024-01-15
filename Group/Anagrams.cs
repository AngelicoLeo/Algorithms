namespace Algoritms.Group
{
    public static class Anagrams
    {
        public static string GroupAnagrams()
        {
            Dictionary<String, String> list = new Dictionary<String, String>();
            var strs = new string[] { "ate", "bat", "tea" };
            foreach (var str in strs)
            {
                var key = String.Concat(str.OrderBy(c => c));
                if (list.ContainsKey(key))
                {
                    list[key] = string.Concat(list[key], str);
                    continue;
                }
                    list[key] = str;
            }
            return string.Join("", list.Values.ToArray());
        }
    }
}
