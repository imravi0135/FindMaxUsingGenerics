using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the generic problems");
            MaxNumber maxNumber = new MaxNumber();
            Console.WriteLine("Maximun Integer Number Is :" + maxNumber.Maximum(10, 20, 15));
            MaxFloatNumber maxfloatnum = new MaxFloatNumber();
            Console.WriteLine("Maximum Float Number Is :" + maxfloatnum.FloatNumber(9.54f, 5.96f, 8.7f));
            MaxString maxString = new MaxString();
            Console.WriteLine("Maximum String Is :" + maxString.maxString("germany", "ukrine", "peru"));
            Console.ReadKey();
        }
    }
}

       

