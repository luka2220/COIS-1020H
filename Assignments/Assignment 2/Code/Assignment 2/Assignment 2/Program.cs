/*
 
Program Documentation

Name: Luka Piplica
Student Number: 0748533

Program Description
This program was written for the purpose of computing the
averages of the Biology, Computer Science, and Physics
departments at Trent University. The program prompts the
user to enter their deparment code, 'B' or 'b' for Biology, 
'C' or 'c' for Computer Science, 'P' or 'p' for Physics, and
'Q' or 'q' to quit the program and view the averages. The user 
is then prompted to enter the mark from 0 - 100, which will be 
used to compute the averages for each mark in the given department.
Once the user quits the program they will be able to view the
average marks for each department they entered.

Data Dictionary
deptCode: A variable of type char to store the deparment code the user enters, and will assign the store the grade based on the input
mark: A variable of type double to store the mark the user inputs, and will be added to the according department mark total
biologyMarkAverage: A variable of type double to store the avreage of biology department marks, its value is biologyMarkTotal / biologyCounter
biologyMarkTotal: A variable of type double which is used to calculate avg. for the biology department
biologyCounter: A variable of type int which is incremented by 1 every time the biology department code is entered, and is used to calculate avg. for the biology department
computerScienceMarkAverage: A variable of type double to store the average of computer science marks, its value is computerScienceMarkTotal / computerScienceCounter
computerScienceMarkTotal: A variable of type double which is for the calculation of the computer science deparment average
computerScienceCounter: A variable of type int which is the number of marks inputted by the user for the cs dept., and is used to calculate the average for the cs. department
physicsMarkAverage: A variable of type double which store the average grades for the physics department, its value is calculated by physicsMarkTotal / physicsCounter
physicsMarkTotal: A variable of type double which is used for the calculation of the physics deparment grade average
physicsCounter: A variable of type int which is the amount of grades inputted for the physics dept., and used to calculate the average grade for the physics department
*/

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

        // Prompting user to input department code
        Console.Write("Enter a department code: ‘C’ or ‘c’ for Computer Science,‘B’ or ‘b’ for Biology, " +
            "‘P’ or ‘p’ for Physics, or enter ‘Q’ or ‘q’ to quit: ");
        deptCode = Convert.ToChar(Console.ReadLine());


        // Sentinal loop to prompt user for department code and mark
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
            else 
            {
                // Prompting error for user to input correct department code
                Console.Write("Error, Enter a correct department code\n");
            }

            // Prompting user input of department code
            Console.Write("Enter a department code: ‘C’ or ‘c’ for Computer Science,‘B’ or ‘b’ for Biology, " +
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
