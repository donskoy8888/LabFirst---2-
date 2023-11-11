using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employee Information");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    DisplayEmployeeInfo(employees);
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 2.");
                    break;
            }
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Employee newEmployee = new Employee(lastName, firstName);
        employees.Add(newEmployee);

        Console.WriteLine("Employee added successfully!");
    }

    static void DisplayEmployeeInfo(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees added yet. Add an employee first.");
            return;
        }

        Console.WriteLine("Select an Employee:");

        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {employees[i].ToString()}");
        }

        Console.Write("Enter the employee number: ");
        int employeeNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (employeeNumber >= 0 && employeeNumber < employees.Count)
        {
            Console.WriteLine("Enter Position: ");
            string position = Console.ReadLine();

            Console.WriteLine("Enter Experience (in years): ");
            int experience = Convert.ToInt32(Console.ReadLine());

            employees[employeeNumber].DisplayEmployeeInfo(position, experience);
        }
        else
        {
            Console.WriteLine("Invalid employee number.");
        }
    }
}
