using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class ResultFinder
    {
        /// <summary>
        /// Properties of the fields of this class
        /// </summary>
        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }

        /// <summary>
        /// Method to display marks obtained
        /// </summary>
        public void DisplayMarks()
        {
            Console.WriteLine("Marks entered------------- ");
            Console.WriteLine($"Marks 1 :{Marks1} ");
            Console.WriteLine($"Marks 2 :{Marks2} ");
            Console.WriteLine($"Marks 3 :{Marks3}");
            Console.WriteLine($"Total :{GetTotal()} ");
            Console.WriteLine($"Average :{GetAverage()} ");
            Console.WriteLine($"Result :{GetResult()} ");
        }

        /// <summary>
        /// Method to get the total of the marks in subjects
        /// </summary>
        /// <returns></returns>
        public int GetTotal()
        {
            int total;
            total=Marks1+ Marks2 + Marks3;
            return total;
        }

        /// <summary>
        /// Method to calculate the average of the marks
        /// </summary>
        /// <returns></returns>
        public double GetAverage()
        {
            double avg;
            avg=GetTotal()/3;
            return avg;

        }

        /// <summary>
        /// Method to get the result for the marks given
        /// </summary>
        /// <returns></returns>
        public string GetResult()
        {
            string Result = "Fail";

            if (GetAverage() > 35)
                Result = "Pass";
            return Result;
        }
    }
}
