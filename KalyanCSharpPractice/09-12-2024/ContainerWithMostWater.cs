using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_12_2024
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] heights)
        {
            int area = 0, left = 0, right = heights.Length - 1, res = 0;

            while (left < right)
            {
                area = Math.Min(heights[left], heights[right]) * (right - left);

                res = Math.Max(area, res);

                if (heights[left] < heights[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
                
            }
            return res;
        }

        public static void Main(string[] args)
        {
            var heights = new int[]{ 2, 2, 2 };

           var result =  MaxArea(heights);

           Console.WriteLine("Max Area is : " + result);
            

        }
    }
}
