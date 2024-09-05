using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_04_2024
{
    internal class MinCostClimbingStairs
    {

        
        public int minCostClimbingStairs(int[] cost)
        {
            for (int i = cost.length - 3; i >= 0; i--)
            {
                cost[i] += Math.min(cost[i + 1], cost[i + 2]);
            }s
            return Math.min(cost[0], cost[1]);
        }
    

    }
}
