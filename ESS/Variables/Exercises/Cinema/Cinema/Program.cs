namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ticket price
            double ticketPrice = 9.10;
            double discountedTicketPrice = 8.10;
            double studentTicketPrice = 6.90;


            //costumers tickets
            int normalTickets = 0;
            int discountedTickets = 0;
            int studentTickets = 0;
            int totalTickets = 0;

            //calculate total cost
            double costNormalTickets = 0;
            double costDiscountedTickets = 0;
            double costStudentTickets = 0;
            double totalCost = 0;

            Console.OutputEncoding = System.Text.Encoding.UTF8; // Set the output encoding to UTF-8 to support € symbol
            Console.WriteLine("=+=+=+=+= CINEMA =+=+=+=+=");
            Console.WriteLine("Welkom to your favorite cinema!\n");
            Console.WriteLine("How many tickets would you like to buy?\n");
            Console.WriteLine($"\t - normal ticket: € {ticketPrice:F2}");
            Console.WriteLine($"\t - discounted ticket: € {discountedTicketPrice:F2}");
            Console.WriteLine($"\t - student ticket: € {studentTicketPrice:F2}");

            Console.WriteLine();

            Console.Write("Number of normal tickets: ");
            if(!int.TryParse(Console.ReadLine(), out normalTickets))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                
            }
            else
            {
                Console.Write("Number of discounted tickets: ");
                if(!int.TryParse(Console.ReadLine(), out discountedTickets))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    
                }
                else
                {
                    Console.Write("Number of student tickets: ");
                    if(!int.TryParse(Console.ReadLine(), out studentTickets))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        
                    }
                    else
                    {
                        totalTickets = normalTickets + discountedTickets + studentTickets;
                        costNormalTickets = normalTickets * ticketPrice;
                        costDiscountedTickets = discountedTickets * discountedTicketPrice;
                        costStudentTickets = studentTickets * studentTicketPrice;
                        totalCost = costNormalTickets + costDiscountedTickets + costStudentTickets;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n\tNormal tickets: {normalTickets} x € {ticketPrice:F2} = € {costNormalTickets:F2}");
                        Console.WriteLine($"\tDiscounted tickets: {discountedTickets} x € {discountedTicketPrice:F2} = € {costDiscountedTickets:F2}");
                        Console.WriteLine($"\tStudent tickets: {studentTickets} x € {studentTicketPrice:F2} = € {costStudentTickets:F2}");
                        Console.ResetColor();

                        Console.WriteLine($"\nTotal tickets: {totalTickets}");
                        Console.WriteLine($"Total cost: € {totalCost:F2}");
                    }
                }
            }

        }
    }
}
