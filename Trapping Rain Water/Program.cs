using System;

namespace Trapping_Rain_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[] { 0,1,0,2,1,0,1,3,2,1,2,1};
            Console.WriteLine(Trap(result));
        }

        static int Trap(int[] height)
        {
            if (height == null || height.Length == 0) return 0;
            int l = 0, r = height.Length - 1, level = 0, res = 0;
            while (l < r)
            {
                int lower = height[height[l] < height[r] ? l++ : r--];
                level = Math.Max(lower, level);
                res += level - lower;
            }
            return res;
        }
    }
}
