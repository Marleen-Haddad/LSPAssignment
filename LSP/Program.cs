using System;
using System.Collections.Generic;
using EmployeeLib;
using EmployeeLib.Interfaces;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {
            Manager manager = new Manager();
            manager.FirstName = "Emma";
            manager.LastName = "Stone";
            manager.CalculatePerHourRate(4);

            IEmployee emp = new CEO();
            emp.FirstName = "Tom";
            emp.LastName = "Lally";
            emp.CalculatePerHourRate(2);

            List<EmployeeWithManager> employeesWithManager = new List<EmployeeWithManager>();
            EmployeeWithManager sales = new Sales();
            sales.AssignManager(manager);
            sales.FirstName = "Motasem";
            sales.LastName = "Armouti";

            employeesWithManager.Add(sales);

            EmployeeWithManager leadDeveloper = new LeadDeveloper();
            leadDeveloper.AssignManager(manager);
            leadDeveloper.FirstName = "Rasheed";
            leadDeveloper.LastName = "Rabatta";

            employeesWithManager.Add(leadDeveloper);

            EmployeeWithManager developer = new Developer();
            developer.AssignManager(leadDeveloper);
            developer.FirstName = "Marleen";
            developer.LastName = "Haddad";

            employeesWithManager.Add(developer);

            foreach (var employeeWithManager in employeesWithManager)
            {
                Console.WriteLine($"{employeeWithManager.FirstName}'s salary is ${employeeWithManager.Salary}/hour.");
            }

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
