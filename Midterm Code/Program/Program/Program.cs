using System;
public static class Program
{
    public static void Main()
    {
        Console.Write("A");
        Console.Write("B");

        Console.ReadLine();
    }

    public static double ComputePay(double salary, double sales) {

        const double FLAT_DEDUCTION = 5.00;
        double employeeNetPay = 0.0;


        if (sales > 0 && sales < 100)
        {
            employeeNetPay = salary + (sales * 0.02) - FLAT_DEDUCTION;
        }
        else if (sales >= 100 && sales <= 500)
        {
            employeeNetPay = salary + (sales * 0.03) - FLAT_DEDUCTION;
        }
        else if (sales > 500 && sales < 1000)
        {
            employeeNetPay = salary + (sales * 0.04) - FLAT_DEDUCTION;
        }
        else if (sales >= 1000)
        {
            employeeNetPay = salary + (sales * 0.05) - FLAT_DEDUCTION;
        }

        return employeeNetPay;
    }
}