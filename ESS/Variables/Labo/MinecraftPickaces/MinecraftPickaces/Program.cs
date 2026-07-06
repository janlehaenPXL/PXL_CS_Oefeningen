namespace MinecraftPickaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pickaxes durability
            int woodPick = 59;
            int goldPick = 32;
            int stonePick = 131;
            int ironPick = 250;
            int diamondPick = 1561;
            int netheritePick = 2031;

            //Mining blocks amount
            int blocks = 0;

            //Player (pl) Pickaxe
            string plPickName = "";
            string plPickMaterial = "";
            int plPickDura = 0;


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=+=+=+=+=+= MINECRAFT =+=+=+=+=+=");
            Console.ResetColor();



            //Player mining
            Console.WriteLine("How many blocks do you wanne mine with your stone pickaxe?");
            Console.Write("Blocks: ");
            if (!int.TryParse(Console.ReadLine(), out blocks))
            {
                Console.WriteLine("Invalid input, restart to try again.");
            }
            else
            {
                stonePick -= blocks;
                if (stonePick < 0)
                {
                    stonePick = 0;
                }
                woodPick -= blocks;
                if (woodPick < 0)
                {
                    woodPick = 0;
                }
                ironPick -= blocks;
                if (ironPick < 0)
                {
                    ironPick = 0;
                }
                goldPick -= blocks;
                if (goldPick < 0)
                {
                    goldPick = 0;
                }
                diamondPick -= blocks;
                if (diamondPick < 0)
                {
                    diamondPick = 0;
                }
                netheritePick -= blocks;
                if (netheritePick < 0)
                {
                    netheritePick = 0;
                }
               


                Console.WriteLine($"The durability of your pickaxe is now {stonePick}.");
                Console.WriteLine();
                Console.WriteLine($"The rest of the pickaxes would have the following durability left:");


                Console.WriteLine($"Wood:\t\t{woodPick} \nIron:\t\t{ironPick}\nGold:\t\t{goldPick} \nDiamond:\t{diamondPick} \nNetherire:\t{netheritePick}");

                //Player Pickaxe making
                Console.WriteLine();
                Console.WriteLine("Now lets see how well you can make you own pickaxe!");
                Console.WriteLine("What is your pickaxe made of?");
                Console.Write("Material: ");
                plPickMaterial = Console.ReadLine();

                Console.WriteLine($"And what is the durability of this {plPickMaterial}-made pickaxe of yours?");
                Console.Write("Durability: ");
                if (!int.TryParse(Console.ReadLine(), out plPickDura))
                {
                    Console.WriteLine("Invalid input, restart to try again.");
                }
                else
                {
                    Console.WriteLine("And finaly, what is the name of this fine crafted pickaxe?");
                    Console.Write("Name: ");
                    plPickName = Console.ReadLine();
                }

               

                Console.WriteLine($"Ah! What a fitting name! \nNow lets see what {plPickName} can do!");
                Console.WriteLine($"So, with {plPickName}, made of {plPickMaterial} and with a durability of {plPickDura}");
                plPickDura -= blocks;
                if (plPickDura < 0)
                {
                    plPickDura = 0;
                }
                Console.WriteLine();
                Console.WriteLine($"You still have {plPickDura} blocks left on your pickaxe!");


            }



        }
    }
}
