using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the number of Employees: ");
            int x = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= x; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");
                char outsource = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: $");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsource == 'y')
                {
                    Console.Write("Additional Charge: $");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourceEmployee(name, hours, value, additional));
                }
                if(outsource == 'n')
                {
                    employees.Add(new Employee(name, hours, value));
                }
                
               
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}