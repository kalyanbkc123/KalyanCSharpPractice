using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._08_28_2024
{
    public class ReverseBits
    {
        public uint reverseBits(uint n)
        {
            uint res = 0;
            for (int i = 0; i < 32; i++)
            {
                uint bit = (n >> i) & 1;
                res += (bit << (31 - i));            
            }

            return res;

        }

        static void Main(string[] args)
        {
            uint num = 00000000000000000000000000010101u;

            ReverseBits reverse = new ReverseBits();
            uint res =  reverse.reverseBits(num);
            Console.WriteLine("The original no. is "+num);
            
            Console.WriteLine(res);

        }
    }
}
