using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    public class Item
    {
        public string Name { get; set; }
        public List<string> accessName;
        public int Value { get; set; }
        public string Effect { get; set; }
        public int durability { get; set; }
        public Item()
        {
            Name = "You didn't give me anything";
            accessName = new List<string>();
            Value = 0;
            Effect = "None";
            durability = 1;
        }
        public string UseEffect()
        {
            string i = "";
            switch (Effect)
            {
                case "Heal1":
                    Heal();
                    i = "\nYou recover 5 HP";
                    break;

                case "Def1":
                    Def();
                    i = "\nYour defense goes up by 2";
                    break;

                case "Atk1":
                    Atk();
                    i = "\nYour attack goes up by 2";
                    break;

                default:
                    i = "\nThe item has no effect";
                    break;
            }
            return i;
        }
        public void Heal()
        {
            Player.HP = Player.HP + 5;
        }
        public void Def()
        {
            Player.AC = Player.AC + 2;
        }
        public void Atk()
        {
            Player.ATK = Player.ATK + 2;
        }
    }
}
