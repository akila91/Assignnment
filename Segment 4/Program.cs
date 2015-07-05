using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>()
	        {
	            "Australian",
	            "Mongolian",
	            "Russian",
	            "Austrian",
	            "Brazilian"
	        };
            Sort(l, 'M');


        }
       
        public static List<string> Sort(List<string> theList, char theChar)
        {
            List<string> sorted = theList;
            sorted.Sort();
            foreach (string s in sorted)
            {
                if(theChar==s[0])
                Console.WriteLine(s);
            }
            Console.ReadLine();
            return sorted;
        }

      
    }
}
