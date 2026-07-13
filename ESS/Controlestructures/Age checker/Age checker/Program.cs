namespace Age_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=+=+=+=+= Checking age =+=+=+=+=\n");
            int birthYear = 0;
            int currentYear = DateTime.Now.Year;
            bool adult = false;


            Console.Write("Enter your birthyear: ");
            if (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear < 1900 || birthYear > currentYear)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input, restart to try again.");
                Console.ResetColor();
                return;
            }

            int age = currentYear - birthYear;
                     
            Console.WriteLine($"\nYou were born in {birthYear} and it now is {currentYear}, so you are {age} years old!");
            if (age > 18)
            {
                Console.WriteLine("You are over 18, so you're an adult!");
            }
            else
            {
                Console.WriteLine("You are not yet an adult!");
            }



        }
    }
}
