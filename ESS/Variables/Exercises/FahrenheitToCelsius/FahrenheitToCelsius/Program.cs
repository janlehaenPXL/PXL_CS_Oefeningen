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
            double.TryParse(Console.ReadLine(), out fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{fahrenheit} F° is {celsius} C°.");
        }
    }
}
