using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 100;
            int Number2 = 200;

            DisplayValues("Name",Number1,Number2);
            SwapValues(ref Number1,ref Number2);
            DisplayValues("Name", Number1, Number2);
            //Write your logic here

            Console.ReadLine();
        }

        /// <summary>
        /// Method to swap two numbers
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        private static void SwapValues(ref int Number1, ref int Number2)
        {
            int temp;
            temp = Number1;
            Number1 = Number2;
            Number2 = temp;
        }

        /// <summary>
        /// Method to display the numbers before and after swapping
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        private static void DisplayValues(string Str, int Number1, int Number2)
        {
            Console.WriteLine(Str);
            Console.WriteLine("Number 1 = " + Number1);
            Console.WriteLine("Number 2 = " + Number2);
        }
    }
}
