namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int result = 0;
            char calculation = ' ';

            Console.WriteLine("=+=+=+=+=+= Calculator =+=+=+=+=+=\n");
            Console.Write("First integer: ");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again.");
                Console.ResetColor();
                return;
            }
            Console.Write("Second integer: ");
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Choose your calculation (+,-,*,/):");
            Console.Write("Calculation: ");
            if (!char.TryParse(Console.ReadLine(), out calculation))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again.");
                Console.ResetColor();
                return;
            }

            switch (calculation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2; 
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, restart to try again.");
                    Console.ResetColor();
                    return;
            }
            Console.WriteLine($"The result of {number1} {calculation} {number2} = {result}.");
        }
    }
}

