using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FELevelUpCalc;

namespace GenericClasses
{
    public class Mercenary
    {
        int hp = 18;
        int hpGrowth = 50;
        int str = 6;
        int strGrowth = 50;
        int mag = 0;
        int magGrowth = 10;
        int spd = 4;
        int spdGrowth = 35;
        int skl = 3;
        int sklGrowth = 30;
        int def = 5;
        int defGrowth = 35;
        int res = 1;
        int resGrowth = 20;
        int lck = 3;
        int lckGrowth = 20;
        int con = 9;
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
