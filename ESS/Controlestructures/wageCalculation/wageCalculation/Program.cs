using System.Collections.Generic;

namespace wageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string name;
            int workedHours;
            double hourWage;
            double yearWageExlTax;
            double totalTaxes;

            //  =======   Taxes   ======= \\
            double disk1 = 0.00;
            double disk2 = 0.20;
            double disk3 = 0.30;
            double disk4 = 0.40;
            double disk5 = 0.50;

            Console.WriteLine("=+=+=+=+= Wage calculation =+=+=+=+=\n");
            //Getting the information from the user
            Console.Write("Name: ");
            name = Console.ReadLine();
            do
            {
                Console.Write("Worked hours: ");
            } while (!int.TryParse(Console.ReadLine(), out workedHours));
            do
            {
                Console.Write("hourly wage: ");
            } while (!double.TryParse(Console.ReadLine(), out hourWage));

            //calculating the earnings of a whole year
            yearWageExlTax = (double)workedHours * hourWage;

            //calculating the taxes

            // ========= Disk 1 ========= \\
            // 0    -   10,000.00 = 0%

            double lowerLimit1 = 0;
            double upperLimit1 = 10000.00;

            double amountDisk1 = Math.Max(0, Math.Min(yearWageExlTax, upperLimit1) - lowerLimit1);
            double taxAmountDisk1 = amountDisk1 * disk1;

            // ========= Disk 2 ========= \\
            // 10,001.00  -  15,000.00 = 20% 

            double lowerLimit2 = upperLimit1;
            double upperLimit2 = 15000.00;

            double amountDisk2 = Math.Max(0, Math.Min(yearWageExlTax, upperLimit2) - lowerLimit2);
            double taxAmountDisk2 = amountDisk2 * disk2;

            // ========= Disk 3 ========= \\
            // 15,001.00  -  25,000.00 = 30%  

            double lowerLimit3 = upperLimit2;
            double upperLimit3 = 25000.00;

            double amountDisk3 = Math.Max(0, Math.Min(yearWageExlTax, upperLimit3) - lowerLimit3);
            double taxAmountDisk3 = amountDisk3 * disk3;

            // ========= Disk 4 ========= \\
            // 25,001.00  -  50,000.00 = 40% 

            double lowerLimit4 = upperLimit3;
            double upperLimit4 = 50000.00;

            double amountDisk4 = Math.Max(0, Math.Min(yearWageExlTax, upperLimit4) - lowerLimit4);
            double taxAmountDisk4 = amountDisk4 * disk4;

            // ========= Disk 5 ========= \\
            // 50,000.00   -    <   = 50% 

            double lowerLimit5 = upperLimit4;
            double upperLimit5 = double.MaxValue;

            double amountDisk5 = Math.Max(0, Math.Min(yearWageExlTax, upperLimit5) - lowerLimit5);
            double taxAmountDisk5 = amountDisk5 * disk5;


            totalTaxes = taxAmountDisk1 + taxAmountDisk2 + taxAmountDisk3 + taxAmountDisk4 + taxAmountDisk5;


            Console.WriteLine($"Your taxes {name}: \n\nWorked hours: \t\t{workedHours}hours\nHourly wage:\t\t€{hourWage:F2}\n\nYearly wage before tax: €{yearWageExlTax:F2}\nTax amount:\t\t€{totalTaxes:F2}");




















        }
    }
}
