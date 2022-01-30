using System;

public static class Lab2
{
    public static void Main()
    {
        int idNum;
        double payRate, hours, grossPay;
        string firstName, lastName;

        // prompt the user to enter employee's first name
        Console.Write("Enter employee's first name => ");
        firstName = Console.ReadLine();

        // prompt the user to enter employee's last name
        Console.Write("Enter employee's last name => ");
        lastName = Console.ReadLine();

        // prompt the user to enter a six digit employee number
        Console.Write("Enter a six digit employee's ID => ");
        idNum = Convert.ToInt32(Console.ReadLine());

        // prompt the user to enter the number of hours employee worked
        Console.Write("Enter the number of hours employee worked => ");
        hours = Convert.ToDouble(Console.ReadLine());

        // prompt the user to enter the employee's hourly pay rate
        Console.Write("Enter employee's hourly pay rate: ");
        payRate = Convert.ToDouble(Console.ReadLine());

        // calculate gross pay
        grossPay = hours * payRate;

        // output results
        Console.WriteLine("Employee {0} {1}, (ID: {2}) earned {3:C}",
                firstName, lastName, idNum, grossPay);

        Console.ReadLine();
    }
}