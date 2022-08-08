using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class DecimalSplitter
    {
        /// <summary>
        /// Method to get the whole number from a double
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static int GetWhole(double Number)
        {
            int Value= (int)Number;
            return Value;
        }

        /// <summary>
        /// Method to get the fractional part of a double number
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static double GetFraction(double Number)
        {
            double value;
            value= Number-(int)Number;
            return value;
        }

        /// <summary>
        /// Method to check if a given number is odd or even
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static bool IsOdd(double Number)
        {
            return false;
        }
    }
}
