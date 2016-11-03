using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
    public class Player
    {
        public int HP { get; set; }
        public int AC { get; set; }
        public int ATK { get; set; }
        public int DMG { get; set; }
        public int Lvl { get; set; }
        public int EXP { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public List<Item> Inventory;
        public int Location { get; set; }

        List<Item> playerItems = new List<Item>();

        public Player()
        {
            HP = 20;
            ATK = 1;
            Lvl = 1;
            EXP = 0;
            Location = 0;
            Weapon = new Weapon();
            Armor = new Armor();
            Inventory = new List<Item>();
            Weapon.Name = "Wooden Stick";
            Weapon.attackValue = 1;
            Armor.Name = "Tattered Shirt";
            DMG = ATK + Weapon.attackValue;
            AC = Armor.armorValue;
            Location = 1;
        }

        public int weaponAttack()
        {
            int result = 0;

            RandomDice rand = new RandomDice();

            result = rand.rollDice(6) + DMG;

            return result;

        }

        public void levelUp()
        {
            if(EXP >= 100)
            {
                EXP = EXP - 100;
                Lvl++;
            }
        }

        public bool checkIfDead()
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
