using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RegularExpressionMatching_10
    {
        //https://medium.com/@araneznorman/regular-expression-matching-125e246ff3da
        public bool IsMatch(string s, string p)
        {
            // base case: if p is empty, return whether s is empty
            if (p.Length == 0) return s.Length == 0;

            // check if the first characters of s and p match, or if p's first character is '.'
            bool firstMatch = s.Length != 0 && (s[0] == p[0] || p[0] == '.');

            // if p's second character is '*'
            if (p.Length >= 2 && p[1] == '*')
            {
                // return whether zero or more of the preceding element match
                return IsMatch(s, p.Substring(2)) || (firstMatch && IsMatch(s.Substring(1), p));
            }
            else
            {
                // return whether the first characters match and the rest of the strings match
                return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
            }
        }
    }
}
