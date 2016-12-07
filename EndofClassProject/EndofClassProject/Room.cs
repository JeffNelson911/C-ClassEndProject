using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{

    public class Room
    {
        public int RID { get; set; }
        public string rName { get; set; }
        public string rDesc { get; set; }

        //trying something new here. These are the directions in the game.

        public Room north,south, east, west = null;
        public Room northeast, northwest, southeast, southwest = null;
        public Room up, down = null;

        public List<Creature> mobList;
        public List<string> exitList;
        public List<Item> itemList;
        

        //generic room. Nothing special.
        public Room()
        {
            mobList = new List<Creature>();
            itemList = new List<Item>();
            RID = -1;
            rName = "Bob";
            rDesc = "Instantiate me properly!";
        }

        //For quickly making a room.
        public Room(int RoomID, string RoomName, string Description)
        {
            mobList = new List<Creature>();
            itemList = new List<Item>();
            exitList = new List<string>();
            RID = RoomID;
            rName = RoomName;
            rDesc = Description;
        }

        //for completely making a room.
        public Room(List<Creature> creature, List<Item> items, List<string> exitList, int RoomID, string RoomName, string Description)
        {
            mobList = creature;
            itemList = items;
            RID = RoomID;
            rName = RoomName;
            rDesc = Description;
        }

        public void checkDeaths()
        {
            foreach (Creature val in mobList)
            {
                if (val.HP <= 0)
                {
                    val.isdead = true;
                }
            }
            for (int i = 0; i < mobList.Count; i++)
            {
                if (this.mobList[i].isdead == true)
                {
                    this.mobList.RemoveAt(i);
                }
            }
        }

        public void setDirection(string dir, Room room)
        {
            if (dir.Equals("n") || dir.Equals("north"))
            {
                north = room;
            }
            else if (dir.Equals("s") || dir.Equals("south"))
            {
                south = room;
            }
            else if (dir.Equals("e") || dir.Equals("east"))
            {
                east = room;
            }
            else if (dir.Equals("w") || dir.Equals("west"))
            {
                west = room;
            }
            else if (dir.Equals("ne") || dir.Equals("northeast"))
            {
                northeast = room;
            }
            else if (dir.Equals("nw") || dir.Equals("northwest"))
            {
                northwest = room;
            }
            else if (dir.Equals("se") || dir.Equals("southeast"))
            {
                southeast = room;
            }
            else if (dir.Equals("sw") || dir.Equals("southwest"))
            {
                southwest = room;
            }
            else if (dir.Equals("u") || dir.Equals("up"))
            {
                up = room;
            }
            else if (dir.Equals("d") || dir.Equals("down"))
            {
                down = room;
            }
            else
            {
                Console.WriteLine("That direction doesn't exist.");
            }
        }

        //this method checks to see if a room has anything in a direction.
        public bool checkDirection(string dir)
        {
            bool hasdir = false;

            if (dir.Equals("n") || dir.Equals("north"))
            {
                if(north != null) { hasdir = true; }
            }
            else if (dir.Equals("s") || dir.Equals("south"))
            {
                if (south != null) { hasdir = true; }
            }
            else if (dir.Equals("e") || dir.Equals("east"))
            {
                if (east != null) { hasdir = true; }
            }
            else if (dir.Equals("w") || dir.Equals("west"))
            {
                if (west != null) { hasdir = true; }
            }
            else if (dir.Equals("ne") || dir.Equals("northeast"))
            {
                if (northeast != null) { hasdir = true; }
            }
            else if (dir.Equals("nw") || dir.Equals("northwest"))
            {
                if (northwest != null) { hasdir = true; }
            }
            else if (dir.Equals("se") || dir.Equals("southeast"))
            {
                if (southeast != null) { hasdir = true; }
            }
            else if (dir.Equals("sw") || dir.Equals("southwest"))
            {
                if (southwest != null) { hasdir = true; }
            }
            else if (dir.Equals("u") || dir.Equals("up"))
            {
                if (up != null) { hasdir = true; }
            }
            else if (dir.Equals("d") || dir.Equals("down"))
            {
                if (down != null) { hasdir = true; }
            }

            return hasdir;
        }

    }
}
