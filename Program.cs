using System;
using BaseClasses;
using Calculations;

namespace Calculations
{
    class LevelUpCalculator
    {
        static void Main(String[] args)
        {
            BaseClass base1 = new BaseClass(1, 5,
                                            10, 50,
                                            1, 45,
                                            1, 40,
                                            1, 35,
                                            1, 30,
                                            1, 25,
                                            1, 20,
                                            1, 15);
            base1.PrintStats();

            Console.WriteLine("How many level ups?");

            int levels = int.Parse(Console.ReadLine());

            base1.LevelUp(levels);

            Console.ReadKey();

            Soldier soldier1 = new Soldier();
            soldier1.PrintStats();

            Console.WriteLine("How many level ups?");

            int levels2 =int.Parse(Console.ReadLine());

            soldier1.LevelUp(levels2);

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

namespace BaseClasses
{
    public class BaseClass(int lvl, int con,
                           int hp, int hpGrowth,
                           int str, int strGrowth,
                           int mag, int magGrowth,
                           int spd, int spdGrowth,
                           int skl, int sklGrowth,
                           int def, int defGrowth,
                           int res, int resGrowth,
                           int lck, int lckGrowth)
    {
     
        public void LevelUp(int levels)
        {
            hp = LevelUpCalculator.LevelUpHP(levels, hp, hpGrowth);
            str = LevelUpCalculator.LevelUpStat(levels, str, strGrowth);
            mag = LevelUpCalculator.LevelUpStat(levels, mag, magGrowth);
            spd = LevelUpCalculator.LevelUpStat(levels, spd, spdGrowth);
            skl = LevelUpCalculator.LevelUpStat(levels, skl, sklGrowth);
            def = LevelUpCalculator.LevelUpStat(levels, def, defGrowth);
            res = LevelUpCalculator.LevelUpStat(levels, res, resGrowth);
            lck = LevelUpCalculator.LevelUpStat(levels, lck, lckGrowth);
            lvl += levels;
            PrintStats();
        }

        public void PrintStats()
        {
            Console.WriteLine("LVL: " + lvl);
            Console.Write("HP: " + hp + " | ");
            Console.WriteLine("HP Growth: " + hpGrowth + "%");
            Console.Write("STR: " + str + " | ");
            Console.WriteLine("STR Growth: " + strGrowth + "%");
            Console.Write("MAG: " + mag + " | ");
            Console.WriteLine("MAG Growth: " + magGrowth + "%");
            Console.Write("SPD: " + spd + " | ");
            Console.WriteLine("SPD Growth: " + spdGrowth + "%");
            Console.Write("SKL: " + skl + " | ");
            Console.WriteLine("SKL Growth: " + sklGrowth + "%");
            Console.Write("DEF: " + def + " | ");
            Console.WriteLine("DEF Growth: " + defGrowth + "%");
            Console.Write("RES: " + res + " | ");
            Console.WriteLine("RES Growth: " + resGrowth + "%");
            Console.Write("LCK: " + lck + " | ");
            Console.WriteLine("LCK Growth: " + lckGrowth + "%");
            Console.WriteLine("CON: " + con);
        }


    }
    public class Soldier
    {
        int hp = 16;
        int hpGrowth = 50;
        int str = 4;
        int strGrowth = 40;
        int mag = 1;
        int magGrowth = 10;
        int spd = 4;
        int spdGrowth = 30;
        int skl = 4;
        int sklGrowth = 30;
        int def = 4;
        int defGrowth = 30;
        int res = 2;
        int resGrowth = 30;
        int lck = 4;
        int lckGrowth = 30;
        int con = 8;
        int lvl = 1;

        public void PrintStats()
        {
            Console.WriteLine("LVL: " + lvl);
            Console.Write("HP: " + hp + " | ");
            Console.WriteLine("HP Growth: " + hpGrowth + "%");
            Console.Write("STR: " + str + " | ");
            Console.WriteLine("STR Growth: " + strGrowth + "%");
            Console.Write("MAG: " + mag + " | ");
            Console.WriteLine("MAG Growth: " + magGrowth + "%");
            Console.Write("SPD: " + spd + " | ");
            Console.WriteLine("SPD Growth: " + spdGrowth + "%");
            Console.Write("SKL: " + skl + " | ");
            Console.WriteLine("SKL Growth: " + sklGrowth + "%");
            Console.Write("DEF: " + def + " | ");
            Console.WriteLine("DEF Growth: " + defGrowth + "%");
            Console.Write("RES: " + res + " | ");
            Console.WriteLine("RES Growth: " + resGrowth + "%");
            Console.Write("LCK: " + lck + " | ");
            Console.WriteLine("LCK Growth: " + lckGrowth + "%");
            Console.WriteLine("CON: " + con);
        }

        public void LevelUp(int levels)
        {
            hp = LevelUpCalculator.LevelUpHP(levels, hp, hpGrowth);
            str = LevelUpCalculator.LevelUpStat(levels, str, strGrowth);
            mag = LevelUpCalculator.LevelUpStat(levels, mag, magGrowth);
            spd = LevelUpCalculator.LevelUpStat(levels, spd, spdGrowth);
            skl = LevelUpCalculator.LevelUpStat(levels, skl, sklGrowth);
            def = LevelUpCalculator.LevelUpStat(levels, def, defGrowth);
            res = LevelUpCalculator.LevelUpStat(levels, res, resGrowth);
            lck = LevelUpCalculator.LevelUpStat(levels, lck, lckGrowth);
            lvl += levels;
            PrintStats();
        }
    }
}
