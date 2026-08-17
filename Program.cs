using System;
using BaseClasses;
using FELevelUpCalc;
using GenericClasses;

//Fire Emblem style level up calculation
namespace FELevelUpCalc
{
    class LevelUpCalculator
    {
        static void Main(String[] args)
        {
            RandClass random = new RandClass();
            random.GenerateAllStats();
            random.GenerateAllGrowths();
            random.PrintStats();

            Console.WriteLine("How many level ups?");

            int levels = int.Parse(Console.ReadLine());

            random.LevelUp(levels);

            Console.ReadKey();

        }
        //Level up system for Hit Points
        public static int LevelUpHP(int levels, int hp, int hpGrowth)
        {
            Random rand = new Random();
            int temp = 0;
            int toAdd = 0;

            for (int rolls = 0; rolls < levels; rolls++)
            {
                if (hp < 60)
                {
                    /*checks if hp is capped and adds guaranteed 
                     * levels if growth is over 100%
                    */
                    toAdd = (hpGrowth / 100);
                    temp = hpGrowth - (toAdd * 100);

                    if (rand.Next(1, 100) <= temp)
                    {
                        hp++;
                    }

                    hp += toAdd;
                   
                }
                //checks hp cap after level up
                if (hp > 60)
                {
                    hp = 60;
                    
                }
            }

            return hp;
        }
        //Individual Stat level up formula
        public static int LevelUpStat(int levels, int stat, int statGrowth)
        {
            Random rand = new Random();
            int temp = 0;
            int toAdd = 0;

            for (int rolls = 0; rolls < levels; rolls++)
            {
                /* Checks for stat cap and guarantees levels if
                 * growth rate is over 100%
                 */
                if (stat < 40)
                {
                    toAdd = (statGrowth / 100);
                    temp = statGrowth - (toAdd * 100);

                    if (rand.Next(1, 100) <= temp)
                    {
                        stat++;
                    }

                    stat += toAdd;

                }
                // Checks stat cap after level up
                if (stat > 40)
                {
                    stat = 40;

                }
            }

            return stat;
        }
    }    
}

