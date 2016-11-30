﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class FlowerQuest : Quest
    {

        private List<Item> inventory = new List<Item>();

        public FlowerQuest()
        {
            questName = "Retrieve the Crysantheum";
            keywords = new string[5];
            keywords[0] = "flower";
            keywords[1] = "crysantheum";
            description = "We need the rare Crysantheum flower for reason.";
            qId = 1;
            prompt = "We need the Crysantheum flower. It is said to be a miracle cure that can solve anything. Can you find it for me?";
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
            switch(state)
            {
                case 0:
                    if(keywords.Contains("flower"))
                    {
                        state++;
                    }
                    break;
                case 1:
                    foreach(Item val in inventory)
                    {
                        if (val.Name.Equals("crysantheum"))
                        {
                            placeholder = val;
                            break;
                        }
                    }
                    if(placeholder != null)
                    {
                        state++;
                    }
                    break;

            }
                
        }

    }
}