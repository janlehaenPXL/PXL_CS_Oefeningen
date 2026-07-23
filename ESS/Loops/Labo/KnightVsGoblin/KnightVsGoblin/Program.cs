namespace KnightVsGoblin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                                                                                                   
            )(          KNIGHT                       GOBLIN          ||
   O-)///////(**)====================>   VS   <====================(**)\\\\\\\)=O
            )(                                                       ||
    
    ==========================================================================
");
            Random rng = new Random();
            //Bool for knightshealth loop
            bool isValidHealth = false;
            //Bool for choise menu loop
            bool isValidMove = false;
            int playerChoise = 0;

            //stats
            int goblinHealth = rng.Next(0,101);
            int knightHealth;

            int goblinATK;
            int knightATK = 10;
            int healingPotion = 10;

            Console.WriteLine("What is the health of you knight?");
            do
            {
                Console.Write("Health: ");
                if(!int.TryParse(Console.ReadLine(), out knightHealth) || knightHealth < 0 || knightHealth > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pleas enter a valid number between 0 and 100!");
                    Console.ResetColor();
                }
                else
                {
                    isValidHealth = true;
                }
            }while(!isValidHealth);

           while (knightHealth > 0 && goblinHealth > 0)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nKnight health:\t{knightHealth}\nGoblin health: \t{goblinHealth}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nDo you want to do:\n ");
                    Console.ResetColor();
                    Console.WriteLine("1: attack\n2: heal");

                    if(!int.TryParse(Console.ReadLine(), out playerChoise) || playerChoise != 1 && playerChoise != 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid choise, only 1 or 2.");
                        Console.ResetColor();
                    }
                    else
                    {
                        isValidMove = true;
                    }
                    goblinATK = rng.Next(5, 17);


                    switch (playerChoise)
                    {
                        case 1:
                            knightHealth -= goblinATK;
                            goblinHealth -= knightATK;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"You attacked the goblim for {knightATK} damage!\nThe goblin attacked you with {goblinATK} damage! ");
                            Console.ResetColor();
                            break;
                        case 2:
                            knightHealth += healingPotion;
                            knightHealth -= goblinATK;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"You took a healing potion and gained {healingPotion} health points back!\nThe goblin attacked you with {goblinATK} damage! ");
                            Console.ResetColor();
                            break;
                    }


                } while (!isValidMove);
                

            }
            if (knightHealth < 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\n\nYour warrior was slain in the battle with the goblin...");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("\n\nThe faul goblin was slain in battle! You won!!");
                Console.ResetColor();
            }

            





        }
    }
}
