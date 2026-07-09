namespace FahrenheitToCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 0;
            double celsius = 0;
            Console.WriteLine("=+=+=+=+= Fahrenheit to Celsius Converter =+=+=+=+=");
            Console.Write("Degrees in Fahrenheit: ");

            //input validation
            if (!double.TryParse(Console.ReadLine(), out fahrenheit))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Restart to try again");
                Console.ResetColor();
            }
            else
            {
                //callculation
                celsius = (fahrenheit - 32) * 5 / 9;

                Console.WriteLine($"{fahrenheit} F° is {celsius} C°.");
            }
                
        }
    }
}
