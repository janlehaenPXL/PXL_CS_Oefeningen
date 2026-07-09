namespace Average_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int number4 = 0;
            int average = 0;

            Console.WriteLine("=+=+=+=+ Average Calculation =+=+=+=+");
            Console.WriteLine("Enter 4 integers and I will calculate the average for you.");
            Console.Write("1: ");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Only integers are allowed.\n Restart the program to try again.");
                Console.ResetColor();
            }
            else
            {
                Console.Write("2: ");
                if (!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Only integers are allowed.\n Restart the program to try again.");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("3: ");
                    if (!int.TryParse(Console.ReadLine(), out number3))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Only integers are allowed.\n Restart the program to try again.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("4: ");
                        if (!int.TryParse(Console.ReadLine(), out number4))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Only integers are allowed.\n Restart the program to try again.");
                            Console.ResetColor();
                        }
                        else
                        {
                            average = (number1 + number2 + number3 + number4) / 4;
                            Console.WriteLine($"The average of {number1}, {number2}, {number3}, and {number4} is: {average}");
                        }
                    }
                }
            }
        }
    }
}
