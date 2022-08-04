using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int Marks1, Marks2, Marks3;

            //Accept the values from command line arguments
            Console.WriteLine("Enter 3 marks:");
            Marks1 = CustomConsole.ReadInt();
            Marks2 = CustomConsole.ReadInt();
            Marks3 = CustomConsole.ReadInt();

            //Store the values entered in the object
            ResultFinder Finder = new ResultFinder();
            
            Finder.Marks1 = Marks1;
            Finder.Marks2 = Marks2; 
            Finder.Marks3 = Marks3;

            //Display all the information with the help of get and other methods
            Finder.DisplayMarks();

            Console.ReadLine();
        }
    }
}
