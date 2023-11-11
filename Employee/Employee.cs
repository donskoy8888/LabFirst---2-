class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void DisplayEmployeeInfo(string position, int experience)
    {
        double salary = CalculateSalary(position, experience);
        double tax = CalculateTax(salary);

        Console.WriteLine($"Employee Information:");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary:C}");
        Console.WriteLine($"Tax: {tax:C}");
        Console.WriteLine();
    }

    private double CalculateSalary(string position, int experience)
    {

        double baseSalary = 3000;
        double experienceBonus = 1000 * experience;

        return baseSalary + experienceBonus;
    }

    private double CalculateTax(double salary)
    {
        return 0.2 * salary;
    }
}