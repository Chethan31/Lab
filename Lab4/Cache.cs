using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Cache
    {
        private static int MAX_CAPACITY = 0;

        /// <summary>
        /// Static method to get the maximum capacity of the cache
        /// </summary>
        /// <returns></returns>
        public static int GetMaxCapacity()
        {
            Console.WriteLine("Returning MAX_CAPACITY");
            MAX_CAPACITY=int.Parse(Console.ReadLine());
            return MAX_CAPACITY;
        }
    }
}
