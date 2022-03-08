using System;
public static class Assignment3
{
    const double CC_LIMIT = 2000;
    const double HST = 0.13;
    const double SERVICE_CHARGE = 3.50;

    public static void Main()
    {
        // Variable for storing type of transaction
        char transactionCode;
        // Variable for storing users total balance
        double ccBalance = 0.0;
        // Cost of item or cash withdrawl
        double itemAmount;


        // Prompting user for transaction code
        Console.Write("Enter the transaction code: 'B' or 'b' to buy, " +
            "'C' or 'c' to withdrawl, 'P' or 'p' to make payment " +
            "'D' or 'd' to display balance, and 'Q' or 'q' to quit: ");
        transactionCode = char.ToUpper(Convert.ToChar(Console.ReadLine()));

        // Conditional checking if transaction code is 'Q'
        if (char.ToUpper(transactionCode) == 'Q') {

            // Quitting program
            Environment.Exit(1);
        }

        do {

            // Case for each transaction code
            switch (transactionCode) {

                case 'B':

                    // Reading cost of item
                    itemAmount = ReadAmount();
                    // Buying item
                    BuyAnItem(itemAmount, ref ccBalance);

                    break;

                case 'C':

                    // Reading withdrawl amount
                    itemAmount = ReadAmount();
                    // Withdrawing funds
                    CashWithdrawl(itemAmount, ref ccBalance);

                    break;

                case 'P':

                    // Reading payment amount
                    itemAmount = ReadAmount();
                    // Card Payment 
                    MakePayment(itemAmount, ref ccBalance);

                    break;

                case 'D':

                    // Displaying current card balance
                    Display(ccBalance);

                    break;

            }

            // Prompting user for transaction code
            Console.Write("Enter the transaction code: 'B' or 'b' to buy, " +
                "'C' or 'c' to withdrawl, 'P' or 'p' to make payment " +
                "'D' or 'd' to display balance, and 'Q' or 'q' to quit: ");
            transactionCode = char.ToUpper(Convert.ToChar(Console.ReadLine()));

        } while (transactionCode != 'Q');


        Console.ReadLine();
    }

    // Method that reads the amount the user inputted
    public static double ReadAmount() {

        // Prompting the user for the amount
        Console.Write("Enter the amount of the Item/Withdrawl(Positive value): ");
        double amount = Convert.ToDouble(Console.ReadLine());

        // Looping until amount is a non-negative
        while (amount < 0) {

            // Prompting the user for the amount
            Console.Write("Enter the amount of the Item/Withdrawl(Positive value): ");
            amount = Convert.ToDouble(Console.ReadLine());
        }

        return amount;
    }

    // Method for purchasing items on the card
    public static void BuyAnItem(double itemAmt, ref double ccBalance) {

        // Calculating cost of item with HST of 13%
        itemAmt = (itemAmt * HST) + itemAmt;

        if (itemAmt <= CC_LIMIT)
        {
            ccBalance += itemAmt;
        }
        else
        {
            Console.Write("Current charge exceeds card limit");
        }
    }

    // Method for withdrawing funds
    public static void CashWithdrawl(double cashAmt, ref double ccBalance) {

        // Calculating withdrawl amount with service charge
        cashAmt += cashAmt + SERVICE_CHARGE;

        if (cashAmt <= CC_LIMIT)
        {
            ccBalance += cashAmt;
        }
        else
        {
            Console.Write("Withdrawl unavailable, amount exceeds limit");
        }
    }

    // Method for credit card payments
    public static void MakePayment(double payAmt, ref double ccBalance) {

        // Calculating remainder of card balance after withdrawl
        ccBalance -= payAmt;
    }

    // Method for displaying current card balance 
    public static void Display(double ccBalance) {

        // Display message
        Console.Write("The current balance on the card: {0:C}\n", ccBalance);
    }

}