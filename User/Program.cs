using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        UserManager userManager = new UserManager();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("User Management System");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Display All Users");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddUser(userManager);
                    break;
                case 2:
                    userManager.DisplayAllUsers();
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

    static void AddUser(UserManager userManager)
    {
        Console.Write("Enter Login: ");
        string login = Console.ReadLine();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        User newUser = new User(login, firstName, lastName, age);
        userManager.AddUser(newUser);
    }
}
