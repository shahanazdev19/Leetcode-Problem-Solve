using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LongestPalindrome
    {

        public string LongestPalindrome2(string s)
        {
            if (string.IsNullOrEmpty(s)) return String.Empty;
            var res = string.Empty;
            var reslen = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var p1 = expandAroundCenter(s, i, i);
                if (p1.Length > reslen)
                {
                    reslen = p1.Length;
                    res = p1;
                }

                var p2 = expandAroundCenter(s, i, i + 1);
                if (p2.Length > reslen)
                {
                    reslen = p2.Length;
                    res = p2;
                }
            }

            return res;
        }

        private string expandAroundCenter(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }

            return s.Substring(i + 1, j - i - 1);
        }

        // using dynamic programming
        //public string LongestPalindromeCheck(string s)
        //{
        //    if (string.IsNullOrEmpty(s)) return String.Empty;
        //    var res = string.Empty;
        //    var reslen = 0;
        //    var dp = new bool[s.Length, s.Length];


        //    for (int len = 1; len <= s.Length-1; len++)
        //    {
        //        for (int i = 0; i + len <= s.Length; i++)
        //        {
        //            var aa = len - 2 <= 0;
        //            var bb = len - 2;
        //            var cc = (len - 2 <= 0 || dp[i + 1, len - 2]);
        //            var dd = s[i];
        //            var ee = s[i + len - 1];
        //            dp[i, len] = (len - 2 <= 0 || dp[i + 1, len - 2]) && s[i] == s[i + len - 1];
        //            if (dp[i, len] && len > reslen)
        //            {
        //                res = s.Substring(i, len);
        //            }
        //        }
        //    }

        //    return res;
        //}
    }
}
