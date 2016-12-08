using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndofClassProject
{

    public class roomNodes
    {

    }

    public class LinkedWorld
    {
        public List<Room> worldList = new List<Room>();
        
        //public List<Quest> questList = new List<Quest>();
        public LinkedWorld()
        {
            makeWorld();
        }

        public void makeWorld()
        {
            Room room0 = new Room(0, "Debug room", "You shouldn't be here. You've hit an error.");
            Room room1 = new Room(1, "Outside the Tower", "The tower you seek is here. The outside is surrounded by a relatively wide plain, but despite the plain demeanour, all know that the tower is bad news.");
            Room room2 = new Room(2, "Approaching the Tower", "The tower grows larger now that you are getting closer to it. There are a few branching paths at this point that lead into the surrounding plains.");
            Room room3 = new Room(3, "At the Entrance of the Tower", "The doors of the tower are before you, large and eldritch. It was as if the architect of this place was hired explicitly to make this door the most foreboding door it could possibly be.");

            room1.setDirection("n", room2);
            room2.setDirection("s", room1);
            room2.setDirection("n", room3);
            room3.setDirection("s", room2);

            room1.exitList.Add("North");
            room2.exitList.Add("South");
            room2.exitList.Add("North");
            room3.exitList.Add("South");

            worldList.Add(room0);
            worldList.Add(room1);
            worldList.Add(room2);
            worldList.Add(room3);

            Creature wizard = new Creature();
            wizard.Name = "Wizard Merlin";
            wizard.accessName.Add("merlin");

            room1.mobList.Add(wizard);

            
        }
    }
}
