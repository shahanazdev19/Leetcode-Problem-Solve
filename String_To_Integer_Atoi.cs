﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class String_To_Integer_Atoi
    {
        public int ConvertStringToIntegerAtoi(string str)
        {
            long res = 0;
            var sign = 1;
            str = str.Trim();
            if (string.IsNullOrEmpty(str)) return 0;
            var index = 0;
            if (str[0] == '+' || str[0] == '-')
            {
                sign = str[0] == '+' ? 1 : -1;
                index++;
            }
            while (index < str.Length)
            {
                if (!char.IsNumber(str[index]))
                {
                    break;
                }
                res = res * 10 + str[index] - '0';
                if (res * sign > int.MaxValue) return int.MaxValue;
                if (res * sign < int.MinValue) return int.MinValue;
                index++;
            }

            return (int)res * sign;
        }
    }
}
