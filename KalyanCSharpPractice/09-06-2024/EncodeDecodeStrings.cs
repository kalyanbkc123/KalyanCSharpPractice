using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_06_2024
{
    public class EncodeDecodeStrings
    {

        public static string Encode(List<string> strs)
        {
            return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
        }

        public static List<string> Decode(string s)
        {
            var res = new List<string>();

            var i = 0;
            while( i < s.Length)
            {
                var j = i;
                while (s[j] != '#')
                {
                    ++j;
                }

                int.TryParse(s.Substring(i, j - i), out var len);
                j++;

                res.Add(s.Substring(j, len));
                i = j + len;


            }
           
            return  res;

           
        }

        static void Main(string[] args)
        {
            List<string> arr =new List<string>() { "123", "Hia", "How r you"};

            var res = Encode(arr);

            var res1 = Decode(res);

            foreach(var x in arr)
            {   
                Console.WriteLine(x);
            }
        }
       
    }
}
