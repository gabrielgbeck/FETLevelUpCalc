using System;
using BaseClasses;
using FELevelUpCalc;
using GenericClasses;


namespace FELevelUpCalc
{
    class LevelUpCalculator
    {
        static void Main(String[] args)
        {
            RandClass rand1 = new RandClass();

            rand1.GenerateAllStats();
            rand1.GenerateAllGrowths();
            rand1.PrintStats();

            Console.WriteLine("How many level ups?");

            int levels = int.Parse(Console.ReadLine());

            rand1.LevelUp(levels);

            Console.ReadKey();

        }

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

                if (hp > 60)
                {
                    hp = 60;
                    
                }
            }

            return hp;
        }

        public static int LevelUpStat(int levels, int stat, int statGrowth)
        {
            Random rand = new Random();
            int temp = 0;
            int toAdd = 0;

            for (int rolls = 0; rolls < levels; rolls++)
            {
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

                if (stat > 40)
                {
                    stat = 40;

                }
            }

            return stat;
        }
    }    
}

