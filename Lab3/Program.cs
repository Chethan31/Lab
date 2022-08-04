using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);

            ShowData(Emp);
        }

        static void StoreData(Employee Emp)
        {
            Emp.EmployeeId = int.Parse(Console.ReadLine());
            Emp.Name= Console.ReadLine();
            Emp.Gender=char.Parse(Console.ReadLine());
            Address address = new Address();    
            address.Address1 = Console.ReadLine();
            address.Address2 = Console.ReadLine();
            address.City = Console.ReadLine();
            address.PinCode = int.Parse(Console.ReadLine());
            Emp.EmpAddress = address;
        }

        static void ShowData(Employee Emp)
        {
            //----------------Display the employee information
            Console.WriteLine($"Employee Id :{Emp.EmployeeId} ");
            Console.WriteLine($"Employee Name :{Emp.Name} ");
            Console.WriteLine($"Employee Gender :{Emp.Gender}");

            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine($"Address 1 : {Emp.EmpAddress.Address1}");
           Console.WriteLine($"Address 2 : {Emp.EmpAddress.Address2}");
            Console.WriteLine($"City :  {Emp.EmpAddress.City}");
           Console.WriteLine($"PinCode :{Emp.EmpAddress.PinCode} ");
            Console.WriteLine("----------------------------------");

            Console.ReadLine();
        }
    }
}
