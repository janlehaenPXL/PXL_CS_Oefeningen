namespace SecondsConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds;

            Console.WriteLine("=+=+=+= Seconds Converter =+=+=+= ");
            Console.Write("\nEnter the number of seconds to convert: ");
            if(!int.TryParse(Console.ReadLine(), out seconds))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
                Console.ResetColor();
            }
            else
            {
                int hours = seconds / 3600;
                int minutes = (seconds % 3600) / 60;
                int remainingSeconds = seconds % 60;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{seconds} seconds is equal to {hours} hours, {minutes} minutes, and {remainingSeconds} seconds.");
                Console.ResetColor();
            }
            Console.ReadLine();

        }
    }
}
