using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxFloatNumber
    {
        public float FloatNumber(float num_1, float num_2, float num_3)
        {
            if (num_1.CompareTo(num_2) > 0 && num_1.CompareTo(num_3) > 0)
            {
                return num_1;
            }
            else if (num_2.CompareTo(num_1) > 0 && num_2.CompareTo(num_3) > 0)
            { 
              return num_2;
            }
            else if (num_3.CompareTo(num_1) > 0 && num_3.CompareTo(num_2) > 0)
            { 
                return num_3;
            }
            else
            {
                Console.WriteLine("all are same ");
            }
            return 0;
        }

    }
}
