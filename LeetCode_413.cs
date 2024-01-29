using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LeetCode_413
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int arrayCount = 0;
            int result = 0;
            for (int i = 2; i < nums.Length; ++i)
            {
                Console.WriteLine("array member="+nums[i]);
                if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
                    ++arrayCount;
                else arrayCount = 0;
                Console.WriteLine("count=" + arrayCount);
                result += arrayCount;
            }
            return result;
        }
    }
}
