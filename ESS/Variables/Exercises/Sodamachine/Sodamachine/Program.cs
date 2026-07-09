namespace Sodamachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double userIsertedMoney = 0;
            double sodaPrice = 0;
            double change = 0;
            int changeCents = 0;
            int restCents = 0;

            //Return amount of chain in coins
            int twoEuro = 0;
            int oneEuro = 0;
            int fiftyCent = 0;
            int twintyCent = 0;
            int tenCent = 0;
            int fiveCent = 0;
            int twoCent = 0;
            int oneCent = 0;

            //coins
            int coin2Euro = 200;
            int coin1Euro = 100;
            int coin50Cent = 50;
            int coin20Cent = 20;
            int coin10Cent = 10;
            int coin5Cent = 5;
            int coin2Cent = 2;
            int coin1Cent = 1;


           
            Console.WriteLine("=+=+=+=+= SODA MACHINE =+=+=+=+=");
            Console.Write("Inserted amount of money: ");
            if (!double.TryParse(Console.ReadLine(), out userIsertedMoney))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number.\nRestart to try again.");
                Console.ResetColor();
            }
            else 
            {
                Console.Write("Soda price: ");
                if (!double.TryParse(Console.ReadLine(), out sodaPrice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.\nRestart to try again.");
                    Console.ResetColor();
                }
                else
                {
                    change = userIsertedMoney - sodaPrice;
                    Console.WriteLine($"Change: €{change}");
                    Console.WriteLine("Change in coins: ");
                    Console.WriteLine();

                    changeCents = (int)Math.Round(change * 100);

                    twoEuro = changeCents / coin2Euro;
                    restCents = changeCents % coin2Euro;

                    oneEuro = restCents / coin1Euro;
                    restCents = restCents % coin1Euro;

                    fiftyCent = restCents / coin50Cent;
                    restCents = restCents % coin50Cent;

                    twintyCent = restCents / coin20Cent;
                    restCents = restCents % coin20Cent;

                    tenCent = restCents / coin10Cent;
                    restCents = restCents % coin10Cent;

                    fiveCent = restCents / coin5Cent;
                    restCents = restCents % coin5Cent;

                    twoCent = restCents / coin2Cent;
                    restCents = restCents % coin2Cent;

                    oneCent = restCents / coin1Cent;


                    Console.WriteLine("Change: ");
                    Console.WriteLine($"\t€2:\t {twoEuro}\n\t€1:\t {oneEuro}\n\t€0,50:\t {fiftyCent}\n\t€0,20:\t {twintyCent}\n\t€0,10:\t {tenCent}\n\t€0,05:\t {fiveCent}\n\t€0,02:\t {twoCent}\n\t€0,01:\t {oneCent}\n\n--------------------------------");




                }
            }




        }
    }
}
