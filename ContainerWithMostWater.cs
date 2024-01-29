using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    public class ContainerWithMostWater
    {
        //Given n non-negative integers a1, a2, …, an, where each represents a point at coordinate(i, ai).
        //n vertical lines are drawn such that the two endpoints of line i is at(i, ai) and(i, 0).
        //Find two lines, which together with x-axis forms a container, such that the container contains
        //the most water.

        //Note: You may not slant the container.

        public int MaxArea(int[] height)
        {
            var max = 0;
            var start = 0;
            var end = height.Length - 1;

            while (start < end)
            {
                if (height[start] < height[end])
                {
                    max = Math.Max(max, height[start] * (end - start));
                    start++;
                }
                else
                {
                    max = Math.Max(max, height[end] * (end - start));
                    end--;
                }
            }

            return max;
        }
    }
}
