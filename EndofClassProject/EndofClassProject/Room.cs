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

        public List<Creature> mobList;

        public List<Item> itemList;

        public List<string> exitList;

        //generic room. Nothing special.
        public Room()
        {
            mobList = new List<Creature>();
            itemList = new List<Item>();
            exitList = new List<string>();
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
        public Room(List<Creature> creature, List<Item> items, List<string> exits, int RoomID, string RoomName, string Description)
        {
            mobList = creature;
            itemList = items;
            exitList = exits;
            RID = RoomID;
            rName = RoomName;
            rDesc = Description;
        }

        public void checkDeaths()
        {
            foreach(Creature val in mobList)
            {
                if(val.HP <= 0)
                {
                    val.isdead = true;
                }
            }
            for(int i = 0; i < mobList.Count; i++)
            {
                if (this.mobList[i].isdead == true)
                {
                    this.mobList.RemoveAt(i);
                }
            }
        }

    }
}
