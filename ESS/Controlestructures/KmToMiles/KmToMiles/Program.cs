namespace KmToMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoise;
            double miles = 0;
            double km = 0;
            Console.WriteLine("=+=+=+=+= Km to Miles =+=+=+=+=!\n");
            Console.WriteLine("What do you wish to convert:");
            Console.WriteLine("1: Km to miles");
            Console.WriteLine("2: Miles to km");
            if (!int.TryParse(Console.ReadLine(), out userChoise) || userChoise > 2 || userChoise < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again!");
                Console.ResetColor();
            }
            else
            {
                if (userChoise == 1)
                {
                    Console.Write("Km: ");
                    if (!double.TryParse(Console.ReadLine(), out km))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, restart to try again!");
                        Console.ResetColor();
                    }
                    else
                    {
                        miles = km * 0.621371;
                        Console.WriteLine($"{km}km is {miles} miles.");
                    }
                }
                else
                {

                    Console.Write("Miles: ");
                    if (!double.TryParse(Console.ReadLine(), out miles))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, restart to try again!");
                        Console.ResetColor();
                    }
                    else
                    {
                        km = miles * 1.60934;
                        Console.WriteLine($"{miles} miles is {km}km.");
                    }
                }
            }

        }
    }
}
