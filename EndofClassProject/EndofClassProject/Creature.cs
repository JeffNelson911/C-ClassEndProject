using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EndofClassProject
{
    public class Creature
    {
        public string Name { get; set; }
        public List<string> accessName;
        public string Desc { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int ATK { get; set; }
        public int DMG { get; set; }
        public int Lvl { get; set; }
        public int Exp { get; set; }
        public bool isdead { get; set; }

        public List<Item> mobInventory;
        //public Image i { get; set; }

        /**
         * I turned the stats that should have been numeric into ints so that we could
         * use them for math and various other functions that they would have had to be ints for anyways!
         * Get it to take the objects created in the main form into the moblist in room. I couldn't remember exactly how to do that unless i need to make moblist
         * in main form and pass it as a room constructor requirement??
         * 
         */

        public Creature()
        {
            mobInventory = new List<Item>();
            accessName = new List<string>();
            Name = "Tom";
            Desc = "Tom is upset. Tome notices that you're using the default constructor rather than actually giving a proper description to him. You should go do that now.";
            HP = 10;
            AC = 0;
            ATK = 0;
            Lvl = 1;
            DMG = ATK+Lvl;
            Exp = 10;
            isdead = false;
            //i = Image.FromFile("Bestiary.png");
        }

        public int rollDamage()
        {
            int result = 0;

            RandomDice rand = new RandomDice();

            result = rand.rollDice(3) + DMG;

            return result;
        }

        public void giveXP()
        {
            Player.EXP = Player.EXP + Exp;
        }

        public void dropInv()
        {
            Player.Inventory.AddRange(mobInventory);
        }
    }
}
