using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class EmployeeReport
    {
        /// <summary>
        /// Property of the class
        /// </summary>
        public string ReportDate { get; set; }

        /// <summary>
        /// Method to print a line in a report
        /// </summary>
        private void PrintLine()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
        }

        /// <summary>
        /// Method to display header information of the report
        /// </summary>
        private void DisplayHeader()
        {
            PrintLine();
            Console.WriteLine("EMPLOYEE REPORT\t\t\t\t");
            Console.WriteLine("Date : " + ReportDate);
            PrintLine();
        }

        /// <summary>
        /// Method to display footer information in the report
        /// </summary>
        /// <param name="Count"></param>
        private void DisplayFooter(int Count)
        {
            PrintLine();
            Console.WriteLine("Total Employees : " + Count);
            PrintLine();
        }

        /// <summary>
        /// Method to display employees information
        /// </summary>
        /// <param name="Employees"></param>
        public void DisplayEmployees(Employee[] Employees)
        {
            DisplayHeader();
            int count = 0;
            Console.WriteLine("EMP_ID\tNAME\tROLE\t\tBASIC\tHRA\tALLOW\tSALARY");
            PrintLine();
            foreach (Employee emp in Employees)
            {
                count++;
                Console.WriteLine(emp.EmpId + "\t" + emp.Name + "\t" + RoleBuilder.GetRoleDescription(emp.Role) + "\t" + emp.Basic + "\t" + emp.HRA + "\t" + emp.GetAllowance() + "\t" + emp.GetSalary());
            }
            //Write code here
            DisplayFooter(count);
        }
    }
}
