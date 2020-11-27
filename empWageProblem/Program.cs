using System;
using System.Collections.Generic;
using System.Text;

namespace empWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to employee wage computation problem!");
            EmployeeObject starBucks = new EmployeeObject("Starbucks", 20, 10, 60);
            starBucks.ComputingTheEmployeeSalary();
            Console.WriteLine(starBucks.toString());

        }
    }
}

