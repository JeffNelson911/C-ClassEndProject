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
        //public World world = new World();
        public LinkedWorld world = new LinkedWorld();
        BladeQuest blade;
        FlowerQuest flower;
        Combat combat;


        public Command()
        {
            flower = new FlowerQuest();
            blade = new BladeQuest();
            combat = new Combat();
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
            if (placeholder.Length != 0)
            {
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

                        #region Directions
                        case "n":
                            post = Go("north");
                            break;

                        case "s":
                            post = Go("south");
                            break;
                        case "e":
                            post = Go("east");
                            break;
                        case "w":
                            post = Go("west");
                            break;
                        case "ne":
                            post = Go("northeast");
                            break;
                        case "nw":
                            post = Go("northwest");
                            break;
                        case "se":
                            post = Go("southeast");
                            break;
                        case "sw":
                            post = Go("southwest");
                            break;
                        case "u":
                            post = Go("up");
                            break;
                        case "d":
                            post = Go("down");
                            break;
                        case "north":
                            post = Go("north");
                            break;
                        case "south":
                            post = Go("south");
                            break;
                        case "east":
                            post = Go("east");
                            break;
                        case "west":
                            post = Go("west");
                            break;
                        case "northeast":
                            post = Go("northeast");
                            break;
                        case "northwest":
                            post = Go("northwest");
                            break;
                        case "southeast":
                            post = Go("southeast");
                            break;
                        case "southwest":
                            post = Go("southwest");
                            break;
                        case "up":
                            post = Go("up");
                            break;
                        case "down":
                            post = Go("down");
                            break;
                            #endregion
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
                        case "attack":
                            post = Attack(action);
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


            }
            else
            {
                post = "I need an actual command";
            }
            return post;
        }

        public string QuestHandler(string v, string npc, string act)
        {

            string verb;//This will be the placeholder to determine the verb.
            string action;//This will be the placeholder to determine the action.
            string post = "Try again?";//This will be for holding the output.
            string actor;// This is where the NPC name will go


            verb = v;

            actor = npc;

            action = act;



            foreach (Creature z in world.worldList[Player.Location].mobList)
            {
                if (z.Name.ToLower() == actor)
                {
                    switch (action)
                    {
                        case "flower":
                            post = flower.displayPrompt("flower");
                            flower.checkQuest();
                            break;
                        case "blade":
                            post = "I know about the blade";
                            break;
                        case "type":
                            post = flower.displayPrompt("crysantheum");
                            flower.checkQuest();
                            break;
                        case "guarding":
                            post = flower.displayPrompt("guarding");
                            flower.checkQuest();
                            break;

                    }

                    break;
                }
                else if (z.accessName.Contains(actor))
                {
                    switch (action)
                    {
                        case "flower":
                            post = flower.displayPrompt("flower");
                            flower.checkQuest();
                            break;
                        case "blade":
                            post = "I know about the blade";
                            break;
                        case "type":
                            post = flower.displayPrompt("crysantheum");
                            flower.checkQuest();
                            break;
                        case "guarding":
                            post = flower.displayPrompt("guarding");
                            flower.checkQuest();
                            break;

                    }
                    break;
                }
            }

            //switch (action)
            //{
            //    case "flower":
            //        post = flower.displayPrompt("flower");
            //        break;
            //    case "blade":
            //        post = "I know about the blade";
            //        break;

            //}

            return post;
        }

        public string Attack(string action)
        {
            string result = "There is nothing like that to attack here!";

            Creature placeholder = null;
            foreach (Creature z in world.worldList[Player.Location].mobList)
            {
                if (z.Name.Equals(action))
                {
                    placeholder = z;
                    break;
                }
                else if (z.accessName.Contains(action))
                {
                    placeholder = z;
                    break;
                }
            }
            if (placeholder != null)
            {
                result = "You deal ";
                result += combat.PlayerCombat(placeholder) + " damage to the " + placeholder.Name;
                if(placeholder.HP <= 0)
                {
                    world.worldList[Player.Location].checkDeaths();
                    result += "\nYou've slain the " + placeholder.Name;
                }
                else
                {
                    result += "\nThe " + placeholder.Name + " deals " + combat.MobCombat(placeholder) + "damage to you!";

                    if(Player.HP < 0)
                    {
                        GameOver();
                    }
                }
            }
            

            return result;
        }

        public string Go(string direction)
        {
            string go = "";
            bool playerMoved = false;
            Room dir = null;

            //Check the directions of the world. If the direction exists, copy the room to that direction.
            if (world.worldList[Player.Location].checkDirection(direction))
            {
                playerMoved = true;

                if (direction.Equals("n") || direction.Equals("north"))
                {
                    dir = world.worldList[Player.Location].north;
                }
                else if (direction.Equals("s") || direction.Equals("south"))
                {
                    dir = world.worldList[Player.Location].south;
                }
                else if (direction.Equals("e") || direction.Equals("east"))
                {
                    dir = world.worldList[Player.Location].east;
                }
                else if (direction.Equals("w") || direction.Equals("west"))
                {
                    dir = world.worldList[Player.Location].west;
                }
                else if (direction.Equals("ne") || direction.Equals("northeast"))
                {
                    dir = world.worldList[Player.Location].northeast;
                }
                else if (direction.Equals("nw") || direction.Equals("northwest"))
                {
                    dir = world.worldList[Player.Location].northwest;
                }
                else if (direction.Equals("se") || direction.Equals("southeast"))
                {
                    dir = world.worldList[Player.Location].southeast;
                }
                else if (direction.Equals("sw") || direction.Equals("southwest"))
                {
                    dir = world.worldList[Player.Location].southwest;
                }
                else if (direction.Equals("u") || direction.Equals("up"))
                {
                    dir = world.worldList[Player.Location].up;
                }
                else if (direction.Equals("d") || direction.Equals("down"))
                {
                    dir = world.worldList[Player.Location].down;
                }
                else
                {
                    //just in case.
                    playerMoved = false;
                }
            }

            //if the player moved..
            if (playerMoved == true)
            {
                go = "You move to the " + direction + ".";
                Player.Location = dir.RID;
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

            look = "\n" + world.worldList[Player.Location].rName +
                "\n" + world.worldList[Player.Location].rDesc + 
                "\n";

            foreach(Creature val in world.worldList[Player.Location].mobList)
            {
                look += "\nThere is a " + val.Name + " here.";
            }

            foreach(Item val in world.worldList[Player.Location].itemList)
            {
                look += "\nThere is a " + val.Name + " here.";
            }

            look += "\nThere are ";

            if(world.worldList[Player.Location].exitList.Count != 0)
            {
                foreach(string val in world.worldList[Player.Location].exitList)
                {
                    look += val + " ";
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
            foreach (Item val in world.worldList[Player.Location].itemList)
            {
                if (val.accessName.Contains(Name))
                {
                    placeHolder = val;
                    MessageBox.Show(placeHolder.Name);
                    break;
                }
                else
                {
                    get = "\nPlease select an item to pick up.";

                }
            }
           
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                world.worldList[Player.Location].itemList.Remove(placeHolder);
                Player.Inventory.Add(placeHolder);
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
            foreach (Item val in Player.Inventory)
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
                world.worldList[Player.Location].itemList.Add(placeHolder);
                Player.Inventory.Remove(placeHolder);
                drop = "\nYou pick up the " + placeHolder.Name;
            }
            else
            {
                drop = "\nPlease select a real item to pick up.";

            }


            return drop;
        }
        //public string Open()
        //{
        //    string open = "";



        //    return open;
        //}
        public string Inventory()
        {
            string inventory = "You are holding these items:\n";

            if(Player.Inventory != null)
            {
                foreach (Item val in Player.Inventory)
                {
                    inventory += val.Name + "\n ";
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

            score += Player.EXP;

            return score;
        }
        public string Quit()
        {
            string quit = "Game Over\n" +
                          "Your score was: " + Score() + "\n" +
                          "Have a Nice Day";
            return quit;
        }

        //This is the old code. Keeping it here just in case we need to revert.
        //public bool roomList(string dir, int roomID)
        //{
        //    bool playerMoved = false;

        //    if (dir == "north")
        //    {
        //        switch (roomID)
        //        {
        //            case 0:
        //                Player.Location = 2;
        //                playerMoved = true;
        //                break;
        //            case 2:
        //                Player.Location = 7;
        //                playerMoved = true;
        //                break;
        //            case 8:
        //                Player.Location = 3;
        //                playerMoved = true;
        //                break;
        //            case 9:
        //                Player.Location = 10;
        //                playerMoved = true;
        //                break;
        //            case 10:
        //                Player.Location = 11;
        //                playerMoved = true;
        //                break;
        //            case 15:
        //                Player.Location = 17;
        //                playerMoved = true;
        //                break;
        //            case 17:
        //                Player.Location = 20;
        //                playerMoved = true;
        //                break;
        //            case 19:
        //                Player.Location = 18;
        //                playerMoved = true;
        //                break;
        //            case 24:
        //                Player.Location = 25;
        //                playerMoved = true;
        //                break;
        //            case 29:
        //                Player.Location = 26;
        //                playerMoved = true;
        //                break;
        //            case 32:
        //                Player.Location = 33;
        //                playerMoved = true;
        //                break;
        //            case 36:
        //                Player.Location = 37;
        //                playerMoved = true;
        //                break;
        //            case 38:
        //                Player.Location = 39;
        //                playerMoved = true;
        //                break;
        //            case 41:
        //                Player.Location = 32;
        //                playerMoved = true;
        //                break;
        //            case 42:
        //                Player.Location = 41;
        //                playerMoved = true;
        //                break;
        //            case 45:
        //                Player.Location = 43;
        //                playerMoved = true;
        //                break;
        //            case 46:
        //                Player.Location = 44;
        //                playerMoved = true;
        //                break;
        //            case 47:
        //                Player.Location = 46;
        //                playerMoved = true;
        //                break;
        //            case 52:
        //                Player.Location = 50;
        //                playerMoved = true;
        //                break;
        //            case 55:
        //                Player.Location = 54;
        //                playerMoved = true;
        //                break;
        //        }
        //    }

        public void GameOver()
        {
            MessageBox.Show("You died. Game over!");
            Application.Exit();
        }

        public bool checkMob()
        {
            bool exists = false;
            foreach (Creature val in world.worldList[Player.Location].mobList)
            {
                exists = true;
            }

            return exists;
        }
    }
}
