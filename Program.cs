using System;

namespace FETLevelUpCalc
{
    class LevelUpCalculator
    {
        static void Main(String[] args)
        {
            Soldier soldier1 = new Soldier();
            soldier1.PrintStats();

            Console.WriteLine("How many level ups?");

            int levels = int.Parse(Console.ReadLine());

            soldier1.LevelUp(levels);

            Console.ReadKey();


        }
    }

    public class BaseClass
    {
        public int hp = 0;
        public int hpGrowth = 0;
        public int str = 0;
        public int strGrowth = 0;
        public int mag = 0;
        public int magGrowth = 0;
        public int spd = 0;
        public int spdGrowth = 0;
        public int skl = 0;
        public int sklGrowth = 0;
        public int def = 0;
        public int defGrowth = 0;
        public int res = 0;
        public int resGrowth = 0;
        public int lck = 0;
        public int lckGrowth = 0;
        public int con = 0;
        public int lvl = 0;

        public void LevelUp(int levels)
        {
            Random rand = new Random();
            int toAdd;
            int temp = 0;
            int rolls;

            //hp roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (hp < 60)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (hpGrowth / 100);
                    hp += toAdd;
                    temp = hpGrowth - (toAdd * 100);
                    if(rand.Next(1, 100) <= temp)
                    {
                        hp++;
                    }
                }
                //check for stat cap
                if(hp > 60)
                {
                    hp = 60;
                }
            }
            //str roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (str < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (strGrowth / 100);
                    str += toAdd;
                    temp = strGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        str++;
                    }
                }
                //check for stat cap
                if (str > 40)
                {
                    str = 40;
                }
            }
            //mag roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (mag < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (magGrowth / 100);
                    mag += toAdd;
                    temp = magGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        mag++;
                    }
                }
                //check for stat cap
                if (mag > 40)
                {
                    mag = 40;
                }
            }
            //spd roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (spd < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (spdGrowth / 100);
                    spd += toAdd;
                    temp = spdGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        spd++;
                    }
                }
                //check for stat cap
                if (spd > 40)
                {
                    spd = 40;
                }
            }
            //skl roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (skl < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (sklGrowth / 100);
                    skl += toAdd;
                    temp = sklGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        skl++;
                    }
                }
                //check for stat cap
                if (skl > 40)
                {
                    skl = 40;
                }
            }
            //def roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (def < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (defGrowth / 100);
                    def += toAdd;
                    temp = sklGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        def++;
                    }
                }
                //check for stat cap
                if (def > 40)
                {
                    def = 40;
                }
            }
            //res roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (res < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (resGrowth / 100);
                    res += toAdd;
                    temp = resGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        res++;
                    }
                }
                //check for stat cap
                if (res > 40)
                {
                    res = 40;
                }
            }
            //lck roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (lck < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (lckGrowth / 100);
                    lck += toAdd;
                    temp = lckGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        lck++;
                    }
                }
                //check for stat cap
                if (lck > 40)
                {
                    lck = 40;
                }
            }
            lvl += levels;
            //print the changes
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
        int mag = 3;
        int magGrowth = 10;
        int spd = 4;
        int spdGrowth = 40;
        int skl = 4;
        int sklGrowth = 40;
        int def = 4;
        int defGrowth = 40;
        int res = 3;
        int resGrowth = 40;
        int lck = 4;
        int lckGrowth = 40;
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
            Random rand = new Random();
            int toAdd;
            int temp = 0;
            int rolls;

            //hp roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (hp < 60)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (hpGrowth / 100);
                    hp += toAdd;
                    temp = hpGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        hp++;
                    }
                }
                //check for stat cap
                if (hp > 60)
                {
                    hp = 60;
                }
            }
            //str roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (str < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (strGrowth / 100);
                    str += toAdd;
                    temp = strGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        str++;
                    }
                }
                //check for stat cap
                if (str > 40)
                {
                    str = 40;
                }
            }
            //mag roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (mag < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (magGrowth / 100);
                    mag += toAdd;
                    temp = magGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        mag++;
                    }
                }
                //check for stat cap
                if (mag > 40)
                {
                    mag = 40;
                }
            }
            //spd roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (spd < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (spdGrowth / 100);
                    spd += toAdd;
                    temp = spdGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        spd++;
                    }
                }
                //check for stat cap
                if (spd > 40)
                {
                    spd = 40;
                }
            }
            //skl roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (skl < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (sklGrowth / 100);
                    skl += toAdd;
                    temp = sklGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        skl++;
                    }
                }
                //check for stat cap
                if (skl > 40)
                {
                    skl = 40;
                }
            }
            //def roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (def < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (defGrowth / 100);
                    def += toAdd;
                    temp = sklGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        def++;
                    }
                }
                //check for stat cap
                if (def > 40)
                {
                    def = 40;
                }
            }
            //res roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (res < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (resGrowth / 100);
                    res += toAdd;
                    temp = resGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        res++;
                    }
                }
                //check for stat cap
                if (res > 40)
                {
                    res = 40;
                }
            }
            //lck roll
            for (rolls = 0; rolls < levels; rolls++)
            {
                if (lck < 40)
                {
                    /* in case the growth is over 100,
                     * this will add the guaranteed points 
                     * for the level up.
                     */
                    toAdd = (lckGrowth / 100);
                    lck += toAdd;
                    temp = lckGrowth - (toAdd * 100);
                    if (rand.Next(1, 100) <= temp)
                    {
                        lck++;
                    }
                }
                //check for stat cap
                if (lck > 40)
                {
                    lck = 40;
                }
            }
            lvl += levels;
            //print the changes
            PrintStats();
        }
    }
}