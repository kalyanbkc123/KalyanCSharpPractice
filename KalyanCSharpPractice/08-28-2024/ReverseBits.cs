using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_28_2024
{
    public class ReverseBits
    {    
            public int reverseBits(int n)
            {

                int result = 0;

                for (int i = 0; i < 32; i++)
                {
                    int bit = (n >> i) & 1;
                    result += (bit << (31 - i));
                }

                return result;

            }       

        static void Main(string[] args)
        { 
            
        
        }
    }
}
