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
            Console.WriteLine("Maximun Number Is :" + maxNumber.Maximum(10, 20, 15));
            Console.ReadKey();
        }
    }
}

       

