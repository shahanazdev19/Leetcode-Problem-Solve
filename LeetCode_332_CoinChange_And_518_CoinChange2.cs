using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LeetCode_332_CoinChange_And_518_CoinChange2
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount+1);
            dp[0] = 0;

            for (int i = 0; i < amount; i++)
            {
                foreach (var coin in coins)
                {
                    if(i<coin) continue; 
                    dp[i] =Math.Min(dp[i],dp[i- coin]+1);
                } 
            }
            return dp[amount]==amount+1?-1:dp[amount];
        }
    }
}
