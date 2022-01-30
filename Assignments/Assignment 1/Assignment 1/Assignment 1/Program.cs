/*

Program Documentation

Name: Luka Piplica
Student Number: 0748533

Description
The purpose of this program is to help Hurley's Bakery compute 
the cost of purchasing mini pies for customers. The progam prompts
the user to enter the customers lastname and amount of mini pies 
purchased. With the give inputs the program then computes the total
cost for the customer, and displays the customers lastname, amount of
pies purchased, and the total cost.

Data Dictionary
HST: A constant double variable to store HST of the product which is 13%(0.13), and is used in the total cost calulcation
COVER_CHARGE: A constant double variable to store the cover charge of the pies $0.50(0.50), and is used to calculate the total cost
CustomerLastName: A variable of type String from user input, and is used to store the last name of the customer for output
MiniPiesPurchased: A variabe of type Int from user input, and is used to store amount of pies purchased for calculating the total cost and for output
TotalCost: A variable of type double, and is used to compute and display the total cost of mini pies for the customer

*/


using System;

public static class Assignment1
{
    public static void Main() 
    {
        // Declaring constant variable for HST which is 13%
        const double HST = 0.13;
        // Declaring constant variable for cover charge which is $0.50
        const double COVER_CHARGE = 0.50;

        // Prompting input of customers last name
        Console.Write("Enter customers last name: ");
        // Storing last name in string var
        String CustomerLastName = Console.ReadLine();

        // Prompting input of mini pies purchased
        Console.Write("Enter the amount of mini pies purchased: ");
        // Storing input in variable MiniPiesPurchased
        int MiniPiesPurchased = int.Parse(Console.ReadLine());

        // Checking if MiniPiesPurchased is less than or equal to 0
        if (MiniPiesPurchased <= 0) 
        { 
            // Displaying error message
            Console.Write("At least 1 mini pie must be ordered\n");
            
            // Terminating program
            Environment.Exit(1);
        }

        // Declaring variable to store the total cost
        double TotalCost = 0;

        // Calculating total cost for mini pies purchased
        if (MiniPiesPurchased == 1)
        {
            // For one pie purchased, the cost of the pie is 4.00, plus cover charge
            TotalCost = 4.00 + COVER_CHARGE;

            // Calulating and adding HST to the total cost
            TotalCost += TotalCost * HST;
        }
        else if (MiniPiesPurchased > 1 && MiniPiesPurchased <= 4)
        {
            // Multiplying amount of pies purchased by 3.50 (cost per pie for this range of pies purchased),
            // plus the cover charge
            TotalCost = (MiniPiesPurchased * 3.50) + COVER_CHARGE;

            // Calulating and adding HST to the total cost
            TotalCost += TotalCost * HST;
        }
        else if (MiniPiesPurchased > 4 && MiniPiesPurchased < 8)
        {
            // Multiplying amount of pies purchased by 3.25 (cost per pie for this range of pies purchased),
            // plus the cover charge
            TotalCost = (MiniPiesPurchased * 3.25) + COVER_CHARGE;

            // Calulating and adding HST to the total cost
            TotalCost += TotalCost * HST;
        }
        else if (MiniPiesPurchased >= 8)
        {
            // Multiplying amount of pies purchased by 3.00 (cost per pie for this range of pies purchased),
            // plus the cover charge
            TotalCost = (MiniPiesPurchased * 3.00) + COVER_CHARGE;

            // Checking if amount of pies purchased is less than 12 charge for HST
            if (MiniPiesPurchased < 12)
            {
                // Calulating and adding HST to the total cost
                TotalCost += TotalCost * HST;
            }
        }


        Console.WriteLine("\nOutput");
        // Displaying customers last name
        Console.WriteLine("Customer last name: {0}", CustomerLastName);
        // Displaying the number of mini pies purchased
        Console.WriteLine("Amount of mini pies purchased: {0}", MiniPiesPurchased);
        // Displaying the total cost 
        Console.WriteLine("Total cost of pies purchased: {0:C}", TotalCost);


        Console.ReadLine();
    }
}
