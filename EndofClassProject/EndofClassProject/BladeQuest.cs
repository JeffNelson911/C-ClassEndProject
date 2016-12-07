using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class BladeQuest : Quest
    {

        private List<Item> inventory = new List<Item>();


        public BladeQuest()
        {
            questName = "Retrieve the Vorpal Blade";
            keywords = new string[5];
            keywords[0] = "blade";
            keywords[1] = "vorpal";
            description = "We need the rare Vorpal Blade for reason.";
            qId = 1;
            prompt = "We need the Vorpal Blade. It is said to be a powerful weapon that can pierce any defense. Can you find it for me?";
            state = 0;
        }

        public void copyInventory(List<Item> i)
        {
            inventory = i;
        }

        public override void checkQuest()
        {
            state = 0;
            Item placeholder = null;
            switch (state)
            {
                case 0:
                    if (keywords.Contains("blade"))
                    {
                        state++;
                    }
                    break;
                case 1:
                    foreach (Item val in inventory)
                    {
                        if (val.Name.Equals("vorpal blade"))
                        {
                            placeholder = val;
                            break;
                        }
                    }
                    if (placeholder != null)
                    {
                        state++;
                    }
                    break;
                case 2:
                    break;

            }
        }

        //      Extra Stuff
        //    public bool hasGiven()
        //    {
        //        bool given = false;
        //        Item placeholder = null;
        //        foreach (Item val in Player.Inventory)
        //        {
        //            if (val.Name.Equals("vorpal blade"))
        //            {
        //                placeholder = val;
        //                break;
        //            }
        //        }
        //        if (placeholder != null)
        //        {
        //            given = true;
        //        }
        //        return given;
        //    }
        //}
    }
}


