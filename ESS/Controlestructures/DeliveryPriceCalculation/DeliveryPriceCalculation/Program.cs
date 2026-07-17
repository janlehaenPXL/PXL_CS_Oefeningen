namespace DeliveryPriceCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceProduct;
            int productAmount;
            int taxes;
            Console.WriteLine("=+=+=+= Delivery Price Calculation =+=+=+=\n");

            Console.WriteLine("Whats is the price of the product.");
            Console.Write("Price: ");
            if(!double.TryParse(Console.ReadLine(), out priceProduct))
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
            if (!int.TryParse(Console.ReadLine(), out taxes) || taxes != 6 || taxes != 12 || taxes != 21)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again!");
                Console.ResetColor();
                return;
            }






        }
    }
}
