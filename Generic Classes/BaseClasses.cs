using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FELevelUpCalc;

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

    public class RandClass
    {
        int lvl = 1;
        int con = 5;
        int hp = 0;
        int hpGrowth = 0;
        int str = 0;
        int strGrowth = 0;
        int mag = 0;
        int magGrowth = 0;
        int spd = 0;
        int spdGrowth = 0;
        int skl = 0;
        int sklGrowth = 0;
        int def = 0;
        int defGrowth = 0;
        int res = 0;
        int resGrowth = 0;
        int lck = 0;
        int lckGrowth = 0;
        int ptsRemaining = 26;
        int growthRemaining = 250;

        //generate random stats from a pool of 26 points
        public int GenerateStat()
        {
            if (ptsRemaining > 0)
            {
                Random rand = new Random();
                int toSet = rand.Next(1, 10);
                ptsRemaining -= toSet;

                return toSet;
            }
            else
            { return 0; }

        }

        public void GenerateAllStats()
        {
            str = GenerateStat();
            mag = GenerateStat();
            spd = GenerateStat();
            skl = GenerateStat();
            def = GenerateStat();
            res = GenerateStat();
            lck = GenerateStat();
            con += GenerateStat();
            hp = con * 2;
        }

        //generate growth rates from a pool of 250%
        public int GenerateGrowth()
        {
            if (growthRemaining > 0)
            {
                Random rand = new Random();
                int toSet = rand.Next(1, 80);
                growthRemaining -= toSet;

                return toSet;
            }
            else
            { return 0; }
        }

        public void GenerateAllGrowths()
        {
            hpGrowth = GenerateGrowth();
            strGrowth = GenerateGrowth();
            magGrowth = GenerateGrowth();
            spdGrowth = GenerateGrowth();
            sklGrowth = GenerateGrowth();
            defGrowth = GenerateGrowth();
            resGrowth = GenerateGrowth();
            lckGrowth = GenerateGrowth();
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
}
