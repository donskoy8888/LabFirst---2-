using System;

class Program
{
    static void Main()
    {
        Converter converter = new Converter(35.98, 38.55, 8.68);

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Currency Converter App");
            Console.WriteLine("1. UAH to USD");
            Console.WriteLine("2. UAH to EUR");
            Console.WriteLine("3. UAH to PLN");
            Console.WriteLine("4. USD to UAH");
            Console.WriteLine("5. EUR to UAH");
            Console.WriteLine("6. PLN to UAH");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PerformConversion(converter, "UAH", "USD");
                    break;
                case 2:
                    PerformConversion(converter, "UAH", "EUR");
                    break;
                case 3:
                    PerformConversion(converter, "UAH", "PLN");
                    break;
                case 4:
                    PerformConversion(converter, "USD", "UAH");
                    break;
                case 5:
                    PerformConversion(converter, "EUR", "UAH");
                    break;
                case 6:
                    PerformConversion(converter, "PLN", "UAH");
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                    break;
            }
        }
    }

    static void PerformConversion(Converter converter, string sourceCurrency, string targetCurrency)
    {
        Console.Write($"Enter the amount in {sourceCurrency}: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double convertedAmount = converter.Convert(amount, sourceCurrency, targetCurrency);

        if (convertedAmount != 0)
        {
            Console.WriteLine($"{amount} {sourceCurrency} is approximately {convertedAmount} {targetCurrency}");
        }
    }
}
