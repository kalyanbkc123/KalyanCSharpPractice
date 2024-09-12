using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KalyanCSharpPractice._09_05_2024
{//
    public class AnagramGroup
    {
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            var ans = new Dictionary<string, List<string>>();

            foreach(var s in strs)
            {
                var count = new int[26];
                
                foreach(var c in s)
                {
                    count[c - 'a']++;
                }

                var key = string.Join(",", count);
                
                if(!ans.ContainsKey(key))
                {
                    ans[key] = new List<string>();
                }

                ans[key].Add(s);
            }

            return new List<List<string>>(ans.Values);
        }

        static void Main(string[] args) {

            string[] input = ["act", "pots", "tops", "cat", "stop", "hat"];

            var output = GroupAnagrams(input);

            foreach (var list1 in output)
            {
                Console.Write("[");
                foreach(var list2 in list1)
                {
                    Console.Write(list2+",");
                    
                }
                Console.Write("]");

            }





        }

        
    }
}
