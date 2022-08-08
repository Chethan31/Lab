using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class SalaryCalculator
    {
        /// <summary>
        /// Method to calculate the salary of an employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static double GetSalary(double Basic, double HRA, double AllowancePercentage)
        {
            double salary;
            salary = Basic + HRA + GetAllowance(Basic, AllowancePercentage);
            return salary;
        }

        /// <summary>
        /// Method to get the allowance for an employee based on the percentage
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static double GetAllowance(double Basic,double AllowancePercentage)
        {
            double allowance;
            allowance = Basic * (AllowancePercentage / 100);
            return allowance;
        }
    }
}
