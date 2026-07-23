namespace VendingMachineRedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoise;
            int userInsert;
            double toPay = 0.00;
            double insertAmount = 0.00;
            double change;


            //drinks price
            double sodaPrice = 2.20;
            double waterPrice = 2.00;

            //coins value
            double coin200 = 2.00;
            double coin100 = 1.00;
            double coin50 = 0.50;
            double coin20 = 0.20;
            double coin10 = 0.10;
            double coin5 = 0.05;
            double coin2 = 0.02;
            double coin1 = 0.01;


            //coins amount
            int coin200Amnt;
            int coin100Amnt;
            int coin50Amnt;
            int coin20Amnt;
            int coin10Amnt;
            int coin5Amnt;
            int coin2Amnt;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=+=+=+=+= VENDING MACHINE 2.0 =+=+=+=+=\n");
            Console.WriteLine($"1: Cola 330ml:\t\t€{sodaPrice:F2}\n2: Cola zero 330ml:\t€{sodaPrice:F2}\n3: Fanta 330ml:\t\t€{sodaPrice:F2}\n4: Sprite 330ml:\t€{sodaPrice:F2}\n5: Water plat 500ml:\t€{waterPrice:F2}\n6: Water bruis 500ml:\t€{waterPrice:F2}\n\n");

            do
            {
                Console.WriteLine("Your choise: ");

            } while (!int.TryParse(Console.ReadLine(), out userChoise) || userChoise < 1 && userChoise > 6);

            switch (userChoise)
            {
                case 1:
                    toPay = sodaPrice;
                    break;
                case 2:
                    toPay = sodaPrice;
                    break;
                case 3:
                    toPay = sodaPrice;
                    break;
                case 4:
                    toPay = sodaPrice;
                    break;
                case 5:
                    toPay = waterPrice;
                    break;
                case 6:
                    toPay = waterPrice;
                    break;
            }

            Console.WriteLine($"That will be €{toPay:F2}.");

            //Inserting coins
            Console.WriteLine("Coins:\n1:€2\n2:€1\n3:€0.50\n4:€0.20\n5:€0.10\n6:€0.05\n7:€0.02\n8:€0.01 ");
            do
            {
                Console.WriteLine($"Insert amount: {insertAmount:F2}\nInsert: ");
                if(int.TryParse(Console.ReadLine(), out userInsert)  && userInsert > 0 && userInsert <= 8)
                {
                    switch (userInsert)
                    {
                        case 1:
                            insertAmount = insertAmount + coin200;
                            break;
                        case 2:
                            insertAmount += coin100;
                            break;
                        case 3:
                            insertAmount += coin50;
                            break;
                        case 4:
                            insertAmount += coin10;
                            break;
                        case 5:
                            insertAmount += coin20;
                            break;
                        case 6:
                            insertAmount += coin5;
                            break;
                        case 7:
                            insertAmount += coin2;
                            break;
                        case 8:
                            insertAmount += coin1;
                            break;
                    }
                }
                

            } while (insertAmount < toPay);

            









        }
    }
}
