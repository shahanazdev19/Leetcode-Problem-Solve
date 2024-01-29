using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LeetCode_552_Student_Attendance_Record_II
    {
        public int CheckRecord(int n)
        {
            int[,] dp = new int[2,3];
            dp[0,0] = 1;
            int MOD = 1_000_000_007;
            for (int i = 0; i <= n; i++)
            {
                int[,] tempDp = new int[2,3];
                // if present
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        tempDp[j,0] = (tempDp[j,0] + dp[j,k]) % MOD;
                    }
                }
                // if Absent
                for (int k = 0; k < 3; k++)
                {
                    tempDp[1,0] = (tempDp[1,0] + dp[0,k]) % MOD;
                }
                // if Late
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 1; k < 3; k++)
                    {
                        tempDp[j,k] = (tempDp[j,k] + dp[j,k-1]) % MOD;
                    }
                }
                dp = tempDp;
            }

            int result = 0;
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    result = (result + dp[j,k]) % MOD;
                }
            }
            return result;
        }
       
    }
}
