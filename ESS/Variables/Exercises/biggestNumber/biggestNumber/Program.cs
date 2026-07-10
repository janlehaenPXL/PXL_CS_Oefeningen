namespace biggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;

            Console.WriteLine("=+=+=+=+= Biggest number =+=+=+=+=\n");
            Console.WriteLine("Enter 2 integer numbers and I wil give you the biggist one back.");
            Console.Write("First number: ");
            if(!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again.");
                Console.ResetColor();
            }
            else
            {
                Console.Write("Second number: ");
                if(!int.TryParse(Console.ReadLine(), out number2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, restart to try again.");
                    Console.ResetColor();
                }
                else
                {
                    if(number1 > number2)
                    {
                        Console.WriteLine($"{number1} is the biggest number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number2} is the biggest number.");
                    }
                }
            }

        }
    }
}
