using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class Employee
    {
        /// <summary>
        /// Properties of the class
        /// </summary>
        public string EmpId { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
        public double HRA { get; set; }
        public double AllowancePercentage { get; set; }
        public int Role { get; set; }

        /// <summary>
        /// Method to get the salary of an employee
        /// </summary>
        /// <returns></returns>
        public double GetSalary()
        {
            return SalaryCalculator.GetSalary(Basic,HRA,AllowancePercentage);  
        }

        /// <summary>
        /// Method to get the allowance of an employee
        /// </summary>
        /// <returns></returns>
        public double GetAllowance()
        {
            //Delegation
            return SalaryCalculator.GetAllowance(Basic,AllowancePercentage);
        }
        public Employee(string empId, string name, double basic, double hRA, double allowancePercentage, int role)
        {
            EmpId = empId;
            Name = name;
            Basic = basic;
            HRA = hRA;
            AllowancePercentage = allowancePercentage;
            Role = role;
        }
    }
}
