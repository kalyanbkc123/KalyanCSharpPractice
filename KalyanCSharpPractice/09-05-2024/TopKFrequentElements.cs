using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_05_2024
{
    public class KThLarget
    {
        private PriorityQueue<int, int> minHeap;
        private int k;

        public KThLarget(int k, int[] nums)
        {
            this.k = k;
            this.minHeap = new PriorityQueue<int, int>();

            foreach(int num in nums)
            {
                minHeap.Enqueue(num, num);

                if(minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }

            }
        }

        public int Add(int val)
        {
            minHeap.Enqueue(val, val);
            
            if(minHeap.Count > k)
            {
                minHeap.Dequeue();
            }

            return minHeap.Peek();

        }
    }

    
}
