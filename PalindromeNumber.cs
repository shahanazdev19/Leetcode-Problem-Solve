using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PalindromeNumber
    {
        public bool IsPalindrome2(int x)
        {
            long revert = 0;
            int number = x;
            while (number > 0)
            {
                revert = revert * 10 + number % 10;
                number /= 10;
            }

            return revert == x;
        }
    }
}
