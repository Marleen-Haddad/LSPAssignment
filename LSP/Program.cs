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

            List<Manager> employeesHasManager = new List<Manager>();
            Manager sales = new Sales();
            sales.AssignManager(manager);
            sales.FirstName = "Motasem";
            sales.LastName = "Armouti";
            employeesHasManager.Add(sales);


            Manager leadDeveloper = new LeadDeveloper();
            leadDeveloper.AssignManager(manager);
            leadDeveloper.FirstName = "Rasheed";
            leadDeveloper.LastName = "Rabatta";

            employeesHasManager.Add(leadDeveloper);

            Manager developer = new Developer();
            developer.AssignManager(leadDeveloper);
            developer.FirstName = "Marleen";
            developer.LastName = "Haddad";

            employeesHasManager.Add(developer);

            foreach (var EmployeeHasManager in employeesHasManager)
            {
                Console.WriteLine($"{EmployeeHasManager.FirstName}'s salary is ${EmployeeHasManager.Salary}/hour.");
            }

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
