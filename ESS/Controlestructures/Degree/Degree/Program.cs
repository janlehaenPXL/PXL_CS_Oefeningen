namespace Degree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            // Classes
            int webEss = 0;
            int dataEss = 0;
            int csEss = 0;
            int commSkills = 0;
            int wpl = 0;
            int itOrg = 0;

            //studypoints

            int webEssSP = 6;
            int dataEssSP = 4;
            int csEssSP = 7;
            int commSkillsSP = 3;
            int wplSP = 6;
            int itOrgSP = 4;
            int totalSP = webEssSP + dataEssSP + csEssSP + commSkillsSP + wplSP + itOrgSP;

            //penalty points

            int penaltyPWeb;
            int penaltyPData;
            int penaltyPCs;
            int penaltyPComm;
            int penaltyPwpl;
            int penaltyPIt;
            int totalPenalty;

            Console.WriteLine("=+=+=+=+= Degree =+=+=+=+=\n");
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your points (../20)");
            do
            {
                Console.Write("Web Essentials: ");
            } while (!int.TryParse(Console.ReadLine(), out webEss) || webEss < 0 || webEss > 20);
            do
            {
                Console.Write("Data Essentials: ");
            } while (!int.TryParse(Console.ReadLine(), out dataEss) || dataEss < 0 || dataEss > 20);
            do
            {
                Console.Write("C# Essentials: ");
            } while (!int.TryParse(Console.ReadLine(), out csEss) || csEss < 0 || csEss > 20);
            do
            {
                Console.Write("Communication Skills: ");
            } while (!int.TryParse(Console.ReadLine(), out commSkills) || commSkills < 0 || commSkills > 20);
            do
            {
                Console.Write("WPL: ");
            } while (!int.TryParse(Console.ReadLine(), out wpl) || wpl < 0 || wpl > 20);
            do
            {
                Console.Write("IT-organisation: ");
            } while (!int.TryParse(Console.ReadLine(), out itOrg) || itOrg < 0 || itOrg > 20);


            //penalty points
            penaltyPWeb = Math.Max(0, (10 - webEss) * webEssSP);
            penaltyPData = Math.Max(0, (10 - dataEss) * dataEssSP);
            penaltyPCs = Math.Max(0, (10 - csEss) * csEssSP);
            penaltyPComm = Math.Max(0, (10 - commSkills) * commSkillsSP);
            penaltyPwpl = Math.Max(0, (10 - wpl) * wplSP);
            penaltyPIt = Math.Max(0, (10 - itOrg) * itOrgSP);

            totalPenalty = penaltyPWeb + penaltyPData + penaltyPCs + penaltyPComm + penaltyPwpl + penaltyPIt;

            // avg

            double avgSp = ((double)(webEss * webEssSP) + (dataEss * dataEssSP) + (csEss * csEssSP) + (commSkills * commSkillsSP) + (wpl * wplSP) + (itOrg * itOrgSP)) / totalSP;

            // %
            double spPercent = (avgSp / 20) * 100;

            //End result
            Console.WriteLine($"\n\nName: {name}");
            Console.WriteLine($"Weighted average: {avgSp:F2} / 20 ({spPercent:F2}%)");
            Console.WriteLine($"Total penalty points: {totalPenalty}\n");



            if(totalPenalty > 10)
            {
                Console.WriteLine("You did not pass");
            }
            else
            {
                if (totalPenalty <= 10 && totalPenalty >= 1)
                {
                    Console.WriteLine("Deliberated");
                }
                else
                {
                    if (spPercent >= 85)
                    {
                        Console.WriteLine("Graduated with highest distinction");
                    }
                    else if(spPercent >= 77)
                    {
                        Console.WriteLine("Graduated with great distinction");
                    }
                    else if(spPercent >= 68)
                    {
                        Console.WriteLine("Graduated with distinction");
                    }
                    else
                    {
                        Console.WriteLine("Graduated");
                    }
                }

            }
                     
        }
    }
}
