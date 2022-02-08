using System;
public static class Assignment2
{
    public static void Main()
    {
        // Variable to store the deparment code from user input
        char deptCode;
        // Variable to store mark users inputs
        double mark; 
        // Variable to store biology marks avg
        double biologyMarkAverage = 0.0;
        // Variable to store total marks for biology deparment
        double biologyMarkTotal = 0.0;
        // Counter variable for amount of marks added to biologyMarkTotal
        int biologyCounter = 0;
        // Variable to store computer science marks avg
        double computerScienceMarkAverage = 0.0;
        // Variable to store total marks for computer science deparment
        double computerScienceMarkTotal = 0.0;
        // Counter variable for amount of marks added to computerScienceMarkTotal
        int computerScienceCounter = 0;
        // Variable to hold physics marks avg
        double physicsMarkAverage = 0.0;
        // Variable to store total marks for physics department
        double physicsMarkTotal = 0.0;
        // Counter variable for amount of marks added to physicsMarkTotal
        int physicsCounter = 0;

        // Prompting user input of department code
        Console.Write("Enter a department code: ‘C’ or ‘c’ for Computer Science,‘B’ or ‘b’ for History, " +
            "‘P’ or ‘p’ for Physics, or enter ‘Q’ or ‘q’ to quit: ");
        deptCode = Convert.ToChar(Console.ReadLine());


        //sentinal loop to prompt user for department code and mark
        while (char.ToUpper(deptCode) != 'Q')
        {
            // Loop for validating grade input
            do
            {
                // Reading user input for mark
                Console.Write("Enter the mark (between 0 - 100): ");
                mark = Convert.ToDouble(Console.ReadLine());
            } while (mark < 0 || mark > 100);
           

            // Add mark to department total based on department code
            if (char.ToUpper(deptCode) == 'B')
            {
                // Adding mark to current biology marks total
                biologyMarkTotal += mark;
                // Increasing biology counter by 1
                biologyCounter += 1;
            }
            else if (char.ToUpper(deptCode) == 'C')
            {
                // Adding mark to current computer science marks total
                computerScienceMarkTotal += mark;
                // Increasing computer science counter by 1
                computerScienceCounter += 1;
            }
            else if (char.ToUpper(deptCode) == 'P')
            {
                // Adding mark to current pythics marks total
                physicsMarkTotal += mark;
                // Increasing physics counter by 1
                physicsCounter += 1;
            }

            // Prompting user input of department code
            Console.Write("Enter a department code: ‘C’ or ‘c’ for Computer Science,‘B’ or ‘b’ for History, " +
                "‘P’ or ‘p’ for Physics, or enter ‘Q’ or ‘q’ to quit: ");
            deptCode = Convert.ToChar(Console.ReadLine());
        }

        // Checking if department counters are greater than 0 to compute averages
        if (biologyCounter > 0)
        {
            // Computing average marks for biology students
            biologyMarkAverage = biologyMarkTotal / biologyCounter; 
        }
        if (computerScienceCounter > 0)
        {
            // Computing average marks for computer science students
            computerScienceMarkAverage = computerScienceMarkTotal / computerScienceCounter;
        }
        if (physicsCounter > 0)
        {
            // Computing average marks for physics students
            physicsMarkAverage = physicsMarkTotal / physicsCounter;
        }


        // Displaying department marks
        Console.WriteLine("\nDepartment Mark Averages");
        // Displaying biology mark averages
        Console.WriteLine("Average Marks for Biology Students: {0}", biologyMarkAverage);
        // Displaying computer science mark averages
        Console.WriteLine("Average Marks for Computer Science Students: {0}", computerScienceMarkAverage);
        // Displaying physics mark averages
        Console.WriteLine("Average Marks for Physics Students: {0}", physicsMarkAverage);


        Console.ReadLine();
    }
}
