﻿
namespace ClassLib
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            if (n == 0) return 0;

            int left = 0;
            int right = n - 1;
            int leftMax = 0;
            int rightMax = 0;
            int waterTrapped = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        waterTrapped += leftMax - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        waterTrapped += rightMax - height[right];
                    }
                    right--;
                }
            }

            return waterTrapped;
        }
    }
}