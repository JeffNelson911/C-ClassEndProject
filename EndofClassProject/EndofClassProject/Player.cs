using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    public static class Player
    {
        public static int HP { get; set; }
        public static int AC { get; set; }
        public static int ATK { get; set; }
        public static int DMG { get; set; }
        public static int Lvl { get; set; }
        public static int EXP { get; set; }
        public static Weapon Weapon { get; set; }
        public static Armor Armor { get; set; }
        public static List<Item> Inventory;
        public static int Location { get; set; }

        static List<Item> playerItems = new List<Item>();


        public static void setBaseStats()
        {
            HP = 20;
            AC = 0;
            ATK = 1;
            DMG = 1;
            Lvl = 1;
            EXP = 0;
            Location = 1;
            Armor = new Armor();
            Weapon = new Weapon();
        }


        public static int weaponAttack()
        {
            int result = 0;

            RandomDice rand = new RandomDice();

            result = rand.rollDice(6) + DMG;

            return result;

        }

        public static void levelUp()
        {
            if(EXP >= 100)
            {
                EXP = EXP - 100;
                Lvl++;
            }
        }

        public static bool checkIfDead()
        {
            bool isdead = false;
            if(HP <= 0)
            {
                isdead = true;
            }
            return isdead;
        }

    }
}
