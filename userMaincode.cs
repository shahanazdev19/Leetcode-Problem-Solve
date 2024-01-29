using System;
using System.Collections.Generic;

public static class userMaincode
{
    public static string findVowelcount(string input1)
    {
        int acount = 0; int ecount = 0; int icount = 0; int ocount = 0; int ucount = 0; for (int i = 0; i < input1.Length; i++)
        {
            if (input1[i] == 'a') { acount++; } else if (input1[i] == 'e') { ecount++; } else if (input1[i] == 'i') { icount++; } else if (input1[i] == 'o') { ocount++; } else if (input1[i] == 'u') { ucount++; } else if (input1[i] == 'a') { acount++; } else { continue; }

        }
        int valid = 0;
        if (acount == 1 && ecount == 1 && icount == 1 && ocount == 1 && ucount == 1)
        {
            valid = 1;
        }
        else
        {
            valid = 0;
        }
        if (valid == 1)
        {
            string output = "";
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] != 'a' || input1[i] != 'e' || input1[i] != 'i' || input1[i] != 'o' || input1[i] != 'u')
                {
                    output += input1[i];
                }
            }
            string result = output.ToUpper() + ":" + output.Length.ToString();
            return result;

        }
        else
        {
            string output = "";
            for (int i = input1.Length - 1; i >= 0; i--)
            {
                output += input1[i];
            }
            string result = output.ToUpper() + ":" + "ERROR";
            return result;
        }
    }
}