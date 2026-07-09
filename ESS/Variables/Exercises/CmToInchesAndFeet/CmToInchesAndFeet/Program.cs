namespace CmToInchesAndFeet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centimeter = 0;
            double inches = 0;
            int feet = 0;
            double rest = 0;

            Console.WriteLine("=+=+=+=+=+= Distance converter =+=+=+=+=+=");
            Console.WriteLine();
            Console.Write("Distance in cm: ");
            if(!int.TryParse(Console.ReadLine(), out centimeter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, restart to try again");
                Console.ResetColor();
            }
            else
            {
                inches = centimeter / 2.54;
                feet = (int)Math.Floor(inches / 12);
                rest = inches % 12;

                Console.WriteLine($"{centimeter} cm is {feet} feet and {rest:F2} inches.");

            }
        }
    }
}
