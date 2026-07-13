namespace insuranceCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=+=+=+=+= Insurance =+=+=+=+=\n");
            int userAge;
            string region = " ";
            bool smoker;
            char key = ' ';
            double price = 0.00;
            string smokeInput;

            Console.Write("What is your age: ");
            if (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine("In wich region do you live?");
            Console.WriteLine("1: Flanders\n2: Brussels\n3: Wallonia");
            Console.Write("Number: ");
            int.TryParse(Console.ReadLine(), out int numberRegion);
            switch (numberRegion)
            {
                case 1:
                    region = "Flanders";
                    break;
                case 2:
                    region = "Brussels";
                    break;
                case 3:
                    region = "Wallonia";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, restart to try again.");
                    Console.ResetColor();
                    return;

            }
            Console.WriteLine("Are you a smoker? (y/n)");
            Console.Write("Smoker: ");
            smokeInput = Console.ReadLine().ToUpper();


            if (smokeInput == "Y")
            {
                smoker = true;
            }
            else if (smokeInput == "N")
            {
                smoker = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again.");
                Console.ResetColor();
                return;
            }

            if (userAge < 18)
            {
                price = 0.00;
                Console.WriteLine($"Because you are {userAge} and so under the age of 18, your price is €{price:F2}.");
                return;
            }

            if (userAge < 67)
            {
                price = 150.00;
            }
            if (userAge >= 67)
            {
                price = 300.00;
            }
            if (region == "Brussels")
            {
                price +=200.00;
            }
            if (smoker)
            {
                price *= 2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Because you are a smoker, the price will be doubeld.");
                Console.ResetColor();
            }

            Console.WriteLine($"You are {userAge} years old, live in the region {region}. Your price will be €{price}. ");

        }
    }
}
