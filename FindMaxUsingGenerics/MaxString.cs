using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxString
    {
        public string maxString(string str_1, string str_2, string str_3)

        { 
            if (str_1.CompareTo(str_2) > 0 && str_1.CompareTo(str_3) > 0)
            { 
              
                return str_1;
            }
            else if (str_2.CompareTo(str_1) > 0 && str_2.CompareTo(str_3) > 0)
            {
               
                return str_2;
            }
            else if (str_3.CompareTo(str_1) > 0 && str_3.CompareTo(str_2) > 0)
            {
               
                return str_3;
            }
            else
            {
                Console.WriteLine("all string are equal");
            }
            return null;
        }
    }
}
