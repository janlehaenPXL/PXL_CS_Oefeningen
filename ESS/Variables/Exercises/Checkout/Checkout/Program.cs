namespace Checkout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Set output encoding to UTF-8 for Euro symbol support

            decimal price = 0.0m;
            decimal amount = 0.0m;
            Console.WriteLine("=+=+=+=+= CHECKOUT =+=+=+=+=");
            Console.Write("Enter the price of the item (00,00):");
            if (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Restart to try again.");
                Console.ResetColor();
            }
            else
            {
                Console.Write("Item amount: ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Restart to try again.");
                    Console.ResetColor();
                }
                else
                {
                    decimal total = price * amount;
                    Console.WriteLine($"Total: €{total}");
                }
            }
        }
    }
}
