using static System.Formats.Asn1.AsnWriter;

namespace CountTo20Without3s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a console program that prints the numbers 1 to 20, but:
            //skips all multiples of 3(do not print, but continue)
            //stops completely as soon as you reach 15


            for (int i = 0; i < 20; i++)
            {
                if ((i % 3) == 0)
                {
                    if (i == 15)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                       
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
