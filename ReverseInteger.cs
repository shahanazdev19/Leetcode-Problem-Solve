using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int returnNumber = 0;

            while (true)
            {
                returnNumber = returnNumber * 10 + x % 10;
                x = x / 10;

                if (Math.Abs(x) < 1) break;

                if (returnNumber > Int32.MaxValue / 10) return 0;
                else if (returnNumber < Int32.MinValue / 10) return 0;
            }
            return returnNumber;
        }
    }
}
