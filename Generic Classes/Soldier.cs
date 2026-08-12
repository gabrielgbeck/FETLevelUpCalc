using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FELevelUpCalc;

namespace GenericClasses
{
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
