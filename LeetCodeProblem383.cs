using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LeetCodeProblem383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            Dictionary<char, int> ransomDic = new Dictionary<char, int>();
            Dictionary<char, int> magDic = new Dictionary<char, int>();

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (ransomDic.ContainsKey(ransomNote[i]))
                {
                    ransomDic[ransomNote[i]]++;
                }
                else
                {
                    ransomDic.Add(ransomNote[i], 1);
                }
            }
            for (int i = 0; i < magazine.Length; i++)
            {
                if (magDic.ContainsKey(magazine[i]))
                {
                    magDic[magazine[i]]++;
                }
                else
                {
                    magDic.Add(magazine[i], 1);
                }
            }

            foreach (char c in ransomDic.Keys)
            {
                if (!magDic.ContainsKey(c))
                {
                    return false;
                }
                if (magDic[c] < ransomDic[c])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
