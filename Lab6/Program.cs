using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accept values from the user
            int Number1, Number2;
            Console.WriteLine("Enter Two Numbers:");
            Number1 = CustomConsole.ReadInt();
            Number2 = CustomConsole.ReadInt();



            //Storing the numbers accepted in SwapData object
            SwapData Obj = new SwapData();

            Obj.Number1=Number1;
            Obj.Number2=Number2;

            //Display numbers before swapping
            Obj.DisplayValues("Before Swapping :");

            //Swapping the numbers in the object
            Obj.SwapValues();

            //Display numbers after swapping
            Obj.DisplayValues("After Swapping :");
        }
    }
}
