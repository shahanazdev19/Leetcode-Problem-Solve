using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LengthOfLongestSubstring
    {
        public int lengthOfLongestSubstring(String s)
        {
            int length = 0;
            for (int start = 0; start < s.Length; start++)
            {
                int i = start;
                var dictionary = new Dictionary<char, int>();

                while (i < s.Length && !dictionary.ContainsKey(s[i])) { dictionary.Add(s[i++], 1); }
                if (i - start > length)
                {
                    length = i - start;
                }
            }

            return length;
        }
    }
}
