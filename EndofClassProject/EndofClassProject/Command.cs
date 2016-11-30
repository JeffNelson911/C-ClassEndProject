using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndofClassProject
{
    class Command
    {
        public World world = new World();
        public Player player = new Player();


        public void queue()
        {
            
        }



        public string Handler(string input)
        {
            string[] placeholder;//this is the array the string segments should be going into.
            string cleanupInput;//this will be the placeholder for cleaning up the input and just taking the input in general.
            string verb;//This will be the placeholder to determine the verb.
            string action;//This will be the placeholder to determine the action.
            string post = "Try again?";//This will be for holding the output.
            char[] delim = { ' ', ',', '.', '!', '?' };//this is here to be a delimiter for when I separate words.

            cleanupInput = input.Trim().ToLower();//trim the white space off the input

            //Split the line at delimiters, removing the empty entries.
             placeholder = cleanupInput.Split(delim, StringSplitOptions.RemoveEmptyEntries);//split the string into the string array by the delimiter, remove empty entries

            //Take the verb and the 'action' and set them into separate roles. I could do it with just the array, but this will be easier on the eyes.
            verb = placeholder[0];

            if (placeholder.Length == 1)
            {
                Console.WriteLine(verb);

                switch (verb)
                {
                    case "look":
                        post = Look();
                        break;

                    case "i":
                        post = Inventory();
                        break;

                    case "inventory":
                        post = Inventory();
                        break;

                    case "score":
                        post = Score();
                        break;

                    case "quit":
                        post = Quit();
                        break;
                }
            }
            else if (placeholder.Length == 2)
            {
                action = placeholder[1];
                Console.WriteLine(verb);
                Console.WriteLine(action);

                switch (verb)
                {
                    case "go":
                        post = Go(action);
                        Console.WriteLine("I work!");
                        break;

                    case "take":
                        post = Take(action);
                        break;

                    case "get":
                        post = Get(action);
                        break;

                    case "drop":
                        post = Drop(action);
                        break;

                    case "open":
                        //post = Open(action);
                        break;
                }
            }

            else if (placeholder.Length == 3)
            {
                //have to instantciate and make the npc variable
                //once made you have to place the npc name there
                string npc = placeholder[1];
                action = placeholder[2];

                switch (verb)
                {
                    case "ask":
                        post = QuestHandler("ask", npc, action);
                        break;
                }
            }
            else
            {
                post = "Invalid command. Try again?";
            }


            return post;
        }

        public string QuestHandler(string v,string npc, string act)
        {
            
            string verb;//This will be the placeholder to determine the verb.
            string action;//This will be the placeholder to determine the action.
            string post = "Try again?";//This will be for holding the output.
            string actor;// This is where the NPC name will go
          

            verb = v;

            actor = npc;

            action = act;

            Creature x;

            foreach (Creature z in world.worldList[player.Location].mobList)
            {
                if(z.Name == actor)
                {
                    x = z;
                    break;
                }
                else if(z.accessName.Contains(actor))
                {
                    x = z;
                    break;
                }
            }

            switch(action)
            {
                case "flower":
                    post = "I know about the Flower";
                    break;
                case "blade":
                    post = "I know about the blade";
                    break;

            }
                   
           return post;
        }

        public string Go(string direction)
        {
            string go = "";
            bool playerMoved;

            playerMoved = roomList(direction, world.worldList[player.Location].RID);

            if (playerMoved == true)
            {
                go = "You move to the " + direction + ".";
                Look();
            }
            else
            {
                go = "You can't move to the " + direction + ".";
            }


            return go;
        }
        public string Look()
        {
            string look = "";

            look = "\n" + world.worldList[player.Location].rName +
                "\n" + world.worldList[player.Location].rDesc + 
                "\n";

            foreach(Creature val in world.worldList[player.Location].mobList)
            {
                look += "\nThere is a " + val.Name + " here.";
            }

            foreach(Item val in world.worldList[player.Location].itemList)
            {
                look += "\nThere is a " + val.Name + " here.";
            }

            look += "\nThere are ";

            if(world.worldList[player.Location].exitList.Count != 0)
            {
                foreach(string val in world.worldList[player.Location].exitList)
                {
                    look += val;
                }
            }
            else
            {
                look += " no";
            }

            look += " exits here.";

            return look;
        }
        public string Take(string name)
        {
            string take;

            take = Get(name);

            return take;
        }
        public string Get(string Name)
        {
            string get;
            Item placeHolder = null;

            //for each item in the list, check to see if the selected name matches the item's.
            foreach (Item val in world.worldList[player.Location].itemList)
            {
                if (val.accessName.Contains(Name))
                {
                    placeHolder = val;
                    break;
                }
                else
                {
                    get = "\nPlease select an item to pick up.";

                }
            }
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                player.Inventory.Add(placeHolder);
                world.worldList[player.Location].itemList.Remove(placeHolder);
                get = "\nYou pick up the " + placeHolder.Name;
            }
            else
            {
                get = "\nPlease select a real item to pick up.";

            }

            return get;
        }
        
        public string Drop(string Name)
        {
            string drop = "";
            Item placeHolder = null;

            //for each item in the list, check to see if the selected name matches the item's.
            foreach (Item val in player.Inventory)
            {
                if (val.accessName.Contains(Name))
                {
                    placeHolder = val;
                    break;
                }
                else
                {
                    drop = "\nPlease select an item in your inventory to drop.";

                }
            }
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                world.worldList[player.Location].itemList.Add(placeHolder);
                player.Inventory.Remove(placeHolder);
                drop = "\nYou pick up the " + placeHolder.Name;
            }
            else
            {
                drop = "\nPlease select a real item to pick up.";

            }


            return drop;
        }
        public string Open()
        {
            string open = "";



            return open;
        }
        public string Inventory()
        {
            string inventory = "";

            if(player.Inventory.Count != 0)
            {
                foreach (Item val in player.Inventory)
                {
                    inventory += "\n " + val.Name;
                }
            }
            else
            {
                inventory = "\nYou have nothing in your inventory";
            }


            return inventory;
        }
        public string Score()
        {
            string score = "";

            score += player.EXP;

            return score;
        }
        public string Quit()
        {
            string quit = "Game Over\n" +
                          "Your score was: " + Score() + "\n" +
                          "Have a Nice Day";
            return quit;
        }

        public bool roomList(string dir, int roomID)
        {
            bool playerMoved = false;

            if (dir == "north")
            {
                switch (roomID)
                {
                    case 0:
                        player.Location = 2;
                        playerMoved = true;
                        break;
                    case 2:
                        player.Location = 7;
                        playerMoved = true;
                        break;
                    case 8:
                        player.Location = 3;
                        playerMoved = true;
                        break;
                    case 9:
                        player.Location = 10;
                        playerMoved = true;
                        break;
                    case 10:
                        player.Location = 11;
                        playerMoved = true;
                        break;
                    case 15:
                        player.Location = 17;
                        playerMoved = true;
                        break;
                    case 17:
                        player.Location = 20;
                        playerMoved = true;
                        break;
                    case 19:
                        player.Location = 18;
                        playerMoved = true;
                        break;
                    case 24:
                        player.Location = 25;
                        playerMoved = true;
                        break;
                    case 29:
                        player.Location = 26;
                        playerMoved = true;
                        break;
                    case 32:
                        player.Location = 33;
                        playerMoved = true;
                        break;
                    case 36:
                        player.Location = 37;
                        playerMoved = true;
                        break;
                    case 38:
                        player.Location = 39;
                        playerMoved = true;
                        break;
                    case 41:
                        player.Location = 32;
                        playerMoved = true;
                        break;
                    case 42:
                        player.Location = 41;
                        playerMoved = true;
                        break;
                    case 45:
                        player.Location = 43;
                        playerMoved = true;
                        break;
                    case 46:
                        player.Location = 44;
                        playerMoved = true;
                        break;
                    case 47:
                        player.Location = 46;
                        playerMoved = true;
                        break;
                    case 52:
                        player.Location = 50;
                        playerMoved = true;
                        break;
                    case 55:
                        player.Location = 54;
                        playerMoved = true;
                        break;
                }
            }
            else if (dir == "east")
            {
                switch (roomID)
                {
                    case 0:
                        player.Location = 3;
                        playerMoved = true;
                        break;
                    case 1:
                        player.Location = 0;
                        playerMoved = true;
                        break;
                    case 2:
                        player.Location = 4;
                        playerMoved = true;
                        break;
                    case 4:
                        player.Location = 5;
                        playerMoved = true;
                        break;
                    case 6:
                        player.Location = 1;
                        playerMoved = true;
                        break;
                    case 7:
                        player.Location = 9;
                        playerMoved = true;
                        break;
                    case 10:
                        player.Location = 31;
                        playerMoved = true;
                        break;
                    case 11:
                        player.Location = 12;
                        playerMoved = true;
                        break;
                    case 12:
                        player.Location = 13;
                        playerMoved = true;
                        break;
                    case 13:
                        player.Location = 15;
                        playerMoved = true;
                        break;
                    case 14:
                        player.Location = 17;
                        playerMoved = true;
                        break;
                    case 17:
                        player.Location = 16;
                        playerMoved = true;
                        break;
                    case 16:
                        player.Location = 18;
                        playerMoved = true;
                        break;
                    case 19:
                        player.Location = 20;
                        playerMoved = true;
                        break;
                    case 23:
                        player.Location = 10;
                        playerMoved = true;
                        break;
                    case 24:
                        player.Location = 23;
                        playerMoved = true;
                        break;
                    case 25:
                        player.Location = 26;
                        playerMoved = true;
                        break;
                    case 27:
                        player.Location = 24;
                        playerMoved = true;
                        break;
                    case 28:
                        player.Location = 30;
                        playerMoved = true;
                        break;
                    case 31:
                        player.Location = 32;
                        playerMoved = true;
                        break;
                    case 37:
                        player.Location = 38;
                        playerMoved = true;
                        break;
                    case 40:
                        player.Location = 39;
                        playerMoved = true;
                        break;
                    case 42:
                        player.Location = 43;
                        playerMoved = true;
                        break;
                    case 43:
                        player.Location = 44;
                        playerMoved = true;
                        break;
                    case 48:
                        player.Location = 49;
                        playerMoved = true;
                        break;
                    case 51:
                        player.Location = 50;
                        playerMoved = true;
                        break;
                    case 53:
                        player.Location = 48;
                        playerMoved = true;
                        break;
                    case 54:
                        player.Location = 53;
                        playerMoved = true;
                        break;

                }
            }
            else if (dir == "west")
            {
                switch (roomID)
                {
                    case 0:
                        player.Location = 1;
                        playerMoved = true;
                        break;
                    case 1:
                        player.Location = 6;
                        playerMoved = true;
                        break;
                    case 3:
                        player.Location = 0;
                        playerMoved = true;
                        break;
                    case 4:
                        player.Location = 2;
                        playerMoved = true;
                        break;
                    case 5:
                        player.Location = 4;
                        playerMoved = true;
                        break;
                    case 9:
                        player.Location = 7;
                        playerMoved = true;
                        break;
                    case 10:
                        player.Location = 23;
                        playerMoved = true;
                        break;
                    case 12:
                        player.Location = 11;
                        playerMoved = true;
                        break;
                    case 13:
                        player.Location = 12;
                        playerMoved = true;
                        break;
                    case 15:
                        player.Location = 13;
                        playerMoved = true;
                        break;
                    case 16:
                        player.Location = 17;
                        playerMoved = true;
                        break;
                    case 17:
                        player.Location = 14;
                        playerMoved = true;
                        break;
                    case 18:
                        player.Location = 16;
                        playerMoved = true;
                        break;
                    case 20:
                        player.Location = 11;
                        playerMoved = true;
                        break;
                    case 23:
                        player.Location = 24;
                        playerMoved = true;
                        break;
                    case 24:
                        player.Location = 27;
                        playerMoved = true;
                        break;
                    case 25:
                        player.Location = 27;
                        playerMoved = true;
                        break;
                    case 26:
                        player.Location = 25;
                        playerMoved = true;
                        break;
                    case 27:
                        player.Location = 55;
                        playerMoved = true;
                        break;
                    case 30:
                        player.Location = 28;
                        playerMoved = true;
                        break;
                    case 31:
                        player.Location = 10;
                        playerMoved = true;
                        break;
                    case 32:
                        player.Location = 31;
                        playerMoved = true;
                        break;
                    case 38:
                        player.Location = 37;
                        playerMoved = true;
                        break;
                    case 39:
                        player.Location = 40;
                        playerMoved = true;
                        break;
                    case 40:
                        player.Location = 36;
                        playerMoved = true;
                        break;
                    case 41:
                        player.Location = 54;
                        playerMoved = true;
                        break;
                    case 43:
                        player.Location = 42;
                        playerMoved = true;
                        break;
                    case 44:
                        player.Location = 43;
                        playerMoved = true;
                        break;
                    case 48:
                        player.Location = 53;
                        playerMoved = true;
                        break;
                    case 49:
                        player.Location = 48;
                        playerMoved = true;
                        break;
                    case 50:
                        player.Location = 51;
                        playerMoved = true;
                        break;
                }
            }
            else if (dir == "south")
            {
                switch (roomID)
                {
                    case 2:
                        player.Location = 0;
                        playerMoved = true;
                        break;
                    case 3:
                        player.Location = 8;
                        playerMoved = true;
                        break;
                    case 7:
                        player.Location = 2;
                        playerMoved = true;
                        break;
                    case 10:
                        player.Location = 9;
                        playerMoved = true;
                        break;
                    case 11:
                        player.Location = 10;
                        playerMoved = true;
                        break;
                    case 18:
                        player.Location = 19;
                        playerMoved = true;
                        break;
                    case 20:
                        player.Location = 17;
                        playerMoved = true;
                        break;
                    case 25:
                        player.Location = 24;
                        playerMoved = true;
                        break;
                    case 26:
                        player.Location = 29;
                        playerMoved = true;
                        break;
                    case 32:
                        player.Location = 41;
                        playerMoved = true;
                        break;
                    case 33:
                        player.Location = 32;
                        playerMoved = true;
                        break;
                    case 37:
                        player.Location = 36;
                        playerMoved = true;
                        break;
                    case 39:
                        player.Location = 38;
                        playerMoved = true;
                        break;
                    case 41:
                        player.Location = 42;
                        playerMoved = true;
                        break;
                    case 43:
                        player.Location = 45;
                        playerMoved = true;
                        break;
                    case 44:
                        player.Location = 46;
                        playerMoved = true;
                        break;
                    case 46:
                        player.Location = 47;
                        playerMoved = true;
                        break;
                    case 50:
                        player.Location = 52;
                        playerMoved = true;
                        break;
                    case 54:
                        player.Location = 55;
                        playerMoved = true;
                        break;
                    case 55:
                        player.Location = 27;
                        playerMoved = true;
                        break;
                }
            }
            else if (dir == "northwest")
            {
                switch (roomID)
                {
                    case 17:
                        player.Location = 17;
                        playerMoved = true;
                        break;
                    case 25:
                        player.Location = 28;
                        playerMoved = true;
                        break;
                    case 33:
                        player.Location = 35;
                        playerMoved = true;
                        break;
                    case 38:
                        player.Location = 40;
                        playerMoved = true;
                        break;
                    case 49:
                        player.Location = 47;
                        playerMoved = true;
                        break;
                    case 50:
                        player.Location = 48;
                        playerMoved = true;
                        break;
                }
            }

            else if (dir == "northeast")
            {
                switch (roomID)
                {
                    case 1:
                        player.Location = 2;
                        playerMoved = true;
                        break;
                    case 2:
                        player.Location = 9;
                        playerMoved = true;
                        break;
                    case 12:
                        player.Location = 14;
                        playerMoved = true;
                        break;
                    case 13:
                        player.Location = 27;
                        playerMoved = true;
                        break;
                    case 21:
                        player.Location = 19;
                        playerMoved = true;
                        break;
                    case 35:
                        player.Location = 36;
                        playerMoved = true;
                        break;
                    case 33:
                        player.Location = 34;
                        playerMoved = true;
                        break;
                    case 37:
                        player.Location = 39;
                        playerMoved = true;
                        break;
                    case 48:
                        player.Location = 47;
                        playerMoved = true;
                        break;
                    case 50:
                        player.Location = 49;
                        playerMoved = true;
                        break;
                }
            }

            else if (dir == "southwest")
            {
                switch (roomID)
                {
                    case 2:
                        player.Location = 1;
                        playerMoved = true;
                        break;
                    case 9:
                        player.Location = 2;
                        playerMoved = true;
                        break;
                    case 14:
                        player.Location = 12;
                        playerMoved = true;
                        break;
                    case 19:
                        player.Location = 21;
                        playerMoved = true;
                        break;
                    case 30:
                        player.Location = 25;
                        playerMoved = true;
                        break;
                    case 36:
                        player.Location = 35;
                        playerMoved = true;
                        break;
                    case 39:
                        player.Location = 37;
                        playerMoved = true;
                        break;
                    case 34:
                        player.Location = 33;
                        playerMoved = true;
                        break;
                    case 47:
                        player.Location = 48;
                        playerMoved = true;
                        break;
                    case 49:
                        player.Location = 50;
                        playerMoved = true;
                        break;

                }
            }

            else if (dir == "southeast")
            {
                switch (roomID)
                {
                    case 26:
                        player.Location = 25;
                        playerMoved = true;
                        break;
                    case 35:
                        player.Location = 33;
                        playerMoved = true;
                        break;
                    case 36:
                        player.Location = 34;
                        playerMoved = true;
                        break;
                    case 40:
                        player.Location = 38;
                        playerMoved = true;
                        break;
                    case 47:
                        player.Location = 49;
                        playerMoved = true;
                        break;
                    case 48:
                        player.Location = 50;
                        playerMoved = true;
                        break;
                }
            }
            return playerMoved;
        }

        public bool checkMob()
        {
            bool exists = false;
            foreach (Creature val in world.worldList[player.Location].mobList)
            {
                exists = true;
            }

            return exists;
        }
    }
}
