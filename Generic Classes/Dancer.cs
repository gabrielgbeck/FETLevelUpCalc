using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FELevelUpCalc;

namespace GenericClasses
{
    public class Dancer
    {
        int lvl = 1;
        int con = 6;
        int hp = 12;
        int hpGrowth = 50;
        int str = 1;
        int strGrowth = 25;
        int mag = 1;
        int magGrowth = 25;
        int spd = 6;
        int spdGrowth = 40;
        int skl = 6;
        int sklGrowth = 25;
        int def = 3;
        int defGrowth = 30;
        int res = 3;
        int resGrowth = 30;
        int lck = 5;
        int lckGrowth = 25;

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
