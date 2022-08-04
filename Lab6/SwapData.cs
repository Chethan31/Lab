using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    class SwapData
    {
        /// <summary>
        /// Properties of the class
        /// </summary>
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        /// <summary>
        /// Method to swap values
        /// </summary>
        public void SwapValues()
        {
            int temp=Number1;
            Number1 = Number2;
            Number2 = temp;
        }

        /// <summary>
        /// Method to display values before and after swapping
        /// </summary>
        /// <param name="str"></param>
        public void DisplayValues(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine($"Number1:{Number1}");
            Console.WriteLine($"Number2:{Number2}");
        }
    }
}
