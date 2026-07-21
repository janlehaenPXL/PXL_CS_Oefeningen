namespace enterpriseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enterpriceNumber;
            bool isValid = false;

            Console.WriteLine("=+=+=+=+= Enterprise number =+=+=+=+=\n");
            do
            {
                Console.Write("Enter your enterprice number: ");
                enterpriceNumber = Console.ReadLine();
                enterpriceNumber.Replace(".", "");

               
                if (!int.TryParse(enterpriceNumber, out int enterpriceNr))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, only numbers allowed!");
                    Console.ResetColor();
                }
                else if (enterpriceNumber.Length != 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, must me exact 10 number");
                    Console.ResetColor();
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            







        }
    }
}
