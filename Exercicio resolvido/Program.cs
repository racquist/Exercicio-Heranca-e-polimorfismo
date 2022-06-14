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
                string outsource = Console.ReadLine();

                if(outsource == "y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: $");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional Charge: $");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourceEmployee(name, hours, value, additional);
                    employees.Add(employee);
                }
                if(outsource == "n")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: $");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    Employee employee = new Employee(name, hours, value);
                    employees.Add(employee);

                }
                
               
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee employee in employees)
            {
                int hrs = employee.Hours;
                double vl = employee.ValuePerHour;
                double payment = employee.Payment(hrs, vl);
                Console.WriteLine(employee.Name + " - $" + payment.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}