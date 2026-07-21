namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double price;
            double discount;
            double newPrice;
            double total;

            Console.WriteLine("=+=+=+=+= Discount =+=+=+=+=\n");
            Console.WriteLine("Enter the price and amount of discount!\n");
            Console.Write("Price: ");
            if (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again");
                Console.ResetColor();
                return;

            }

            Console.Write("Discount in %: ");
            if (!double.TryParse(Console.ReadLine(), out discount))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again");
                Console.ResetColor();
                return;
            }

            newPrice = Math.Round(price - (price * (discount / 100)), 2);

            Console.WriteLine($"€{price:F2} - {discount}% = €{newPrice:F2}");



        }


    }
}
