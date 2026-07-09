namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("=+=+=+=+= CALCULATOR =+=+=+=+=");
            Console.Write("Your first number: ");
            int.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Your second number: ");
            int.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");

        }
    }
}
