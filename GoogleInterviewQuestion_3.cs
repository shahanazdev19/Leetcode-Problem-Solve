using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ConsoleApp1
{
    internal class GoogleInterviewQuestion_3
    {
        //Question-3:
        //Given a string, find the length of the longest substring without repeating characters.
        public bool areDistinct(string str,
                               int i, int j)
        {
            // Note : Default values in visited are false
            bool[] visited = new bool[26];

            for (int k = i; k <= j; k++)
            {
                //var data = visited[str[k]];
                var data1 = visited[str[k] - 'a'];
                if (visited[str[k] - 'a'] == true)
                    return false;

                visited[str[k] - 'a'] = true;
            }
            return true;
        }

        // Returns length of the longest substring
        // with all distinct characters.
        public int longestUniqueSubsttr(string str)
        {
            int n = str.Length;

            // Result
            int res = 0;

            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    if (areDistinct(str, i, j))
                        res = Math.Max(res, j - i + 1);

            return res;
        }
    }
}
