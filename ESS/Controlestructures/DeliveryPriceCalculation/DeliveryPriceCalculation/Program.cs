using System.Diagnostics;

namespace DeliveryPriceCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //For a visable euro sign
            double priceProduct;
            double priceExclTax;
            double priceInclTax;
            int productAmount;
            int taxes;
            double deliveryCost = 0.00;
            double total;



            Console.WriteLine("=+=+=+= Delivery Price Calculation =+=+=+=\n");

            Console.WriteLine("Whats is the price of the product.");
            Console.Write("Price: ");
            if (!double.TryParse(Console.ReadLine(), out priceProduct))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again!");
                Console.ResetColor();
                return;
            }
            Console.Write("Amount: ");
            if (!int.TryParse(Console.ReadLine(), out productAmount))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again!");
                Console.ResetColor();
                return;
            }
            Console.Write("Taxes (6/12/21): ");
            if (!int.TryParse(Console.ReadLine(), out taxes) || taxes != 6 && taxes != 12 && taxes != 21)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again!");
                Console.ResetColor();
                return;
            }

            //Price without taxes
            priceExclTax = priceProduct * productAmount;

            //price with taxes
             priceInclTax = (priceExclTax / 100) * (100 + taxes);

            //shipping cost

            if (productAmount >= 10)
            {
                priceExclTax = priceExclTax - (priceExclTax / 100) * 5;
            }

            if (priceExclTax < 50)
            {
                deliveryCost = 15.00;
            }
            else if (priceExclTax < 70)
            {
                deliveryCost = 12.00;
            }
            else
            {
                deliveryCost = 10.00;
            }

            deliveryCost = (deliveryCost / 100) * 106;

            //total cost
            total = priceInclTax + deliveryCost;

            Console.WriteLine();
            Console.WriteLine($"Price before taxes:\t€{priceExclTax:F2}\nTax amount:\t\t{taxes}%\nPrice after taxes:\t€{priceInclTax:F2}\nDeliverycost:\t\t€{deliveryCost:F2}");
            Console.WriteLine();
            Console.WriteLine($"Total:\t\t\t€{total:F2}");




        }
    }
}
