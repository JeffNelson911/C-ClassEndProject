using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndofClassProject
{

    public class LinkedWorld
    {
        public List<Room> worldList = new List<Room>();
        public List<Quest> questList = new List<Quest>();
        
        public LinkedWorld()
        {
            FlowerQuest flower = new FlowerQuest();
            BladeQuest blade = new BladeQuest();

            makeWorld();
            questList.Add(flower);
            questList.Add(blade);
        }

        public void makeWorld()
        {
            #region Room Setup
            Room room0 = new Room(0, "Debug room", "You shouldn't be here. You've hit an error.");
            Room room1 = new Room(1, "Outside The Tower", "The tower you seek is here. The outside is surrounded by a relatively wide plain, but despite the plain demeanour, all know that the tower is bad news.");
            Room room2 = new Room(2, "Path to the Tower", "The tower grows larger now that you are getting closer to it. There are a few branching paths at this point that lead into the surrounding plains.");
            Room room3 = new Room(3, "Path through the Forest", "The doors of the tower are before you, large and eldritch. It was as if the architect of this place was hired explicitly to make this door the most foreboding door it could possibly be.");
            Room room4 = new Room(4, "A Field of Wheat", "A lovely field of golden Wheat as far as the eye can see");
            Room room5 = new Room(5, "Tower Entrance", "The entrance to the Mages Tower. You can feel the surging of magic ");
            Room room6 = new Room(6, "First Level of the Tower", "This level is filled with class rooms and students moving about ");
            Room room7 = new Room(7, "Second Level of the Tower", "This level of the tower seems quieter filled with the dorms");
            Room room8 = new Room(8, "Third Level of the Tower", "This level of the Tower seems the Quietest so far seems like the library and an office are on this level");
            Room room9 = new Room(9, "Library", "A near silent room filled with books and students");
            Room room10 = new Room(10, "Office", "The Arch Mage's Office you hear the hum of active magic near by.");
            Room room11 = new Room(11, "Portal to Somewhere?", "A swirling mass of Arcane that flashes before your eyes as you enter it blinding you as you feel weightless for a moment.");
            Room room12 = new Room(12, "A Dark, Smelly, No-Good, Rotten Cave", "A dark cave that seems to have tracks of activity littering the entrance");
            Room room13 = new Room(13, "Deep within the Woodland.", "This forest seems to be eerily quiet as your head deeper into the forest.");
            Room room14 = new Room(14, "A Peaceful Grove", "A quiet grove that holds a witch looking at the sky and a wolf at her side. You notice a lovely crimson flower near by.");
            Room room15 = new Room(15, "Path to the Cave", "As you look at the cave delving deeper down the path to the cave you feel the last remains of fresh air behind you ");
            Room room16 = new Room(16, "Passage down into the Horrible Cave", "The path way seems to get steeper as you travel the air is musty as you continue down to the bowels of the cave");
            Room room17 = new Room(17, "Twisting Paths of the Cave", "you feel you could get lost if you are not careful in these passageways. The air is thick with the smell of goblins and Kobalds.");
            Room room18 = new Room(18, "Deeper into the Cave", "The path leads you deeper you hear the chatter of Goblins all about you");
            Room room19 = new Room(19, "A hoard of Treasure", "Gold and treasure lay in piles about this room, was it once a hord of a dragon or is this just generations of treasure pillaging from the goblins. You see an edge of a handle that seems out of place here. ");
            #endregion

            #region Room1
            room1.setDirection("n", room2);
            room1.setDirection("e", room3);
            room1.setDirection("w", room4);
            room1.exitList.Add("North");
            room1.exitList.Add("East");
            room1.exitList.Add("West");
            #endregion
            
            #region Room2
            room2.setDirection("s", room1);
            room2.setDirection("n", room5);
            room2.exitList.Add("South");
            room2.exitList.Add("North");
            #endregion

            #region Room3
            room3.exitList.Add("West");
            room3.exitList.Add("East");
            room3.setDirection("w", room1);
            room3.setDirection("e", room13);
            #endregion

            #region Room4
            room4.exitList.Add("East");
            room4.setDirection("e", room1);
            #endregion

            #region Room 5
            room5.exitList.Add("South");
            room5.exitList.Add("North");
            room5.setDirection("s", room2);
            room5.setDirection("n", room6);
            #endregion

            #region Room6
            room6.setDirection("n", room7);
            room6.setDirection("s", room5);
            room6.exitList.Add("North");
            room6.exitList.Add("South");
            #endregion

            #region Room7
            room7.setDirection("n", room8);
            room7.setDirection("s", room6);
            room7.exitList.Add("North");
            room7.exitList.Add("South");
            #endregion

            #region Room8
            room8.setDirection("e", room10);
            room8.setDirection("s", room7);
            room8.setDirection("w", room9);
            room8.exitList.Add("East");
            room8.exitList.Add("South");
            room8.exitList.Add("West");
            #endregion

            #region Room9
            room9.setDirection("e", room8);
            room9.exitList.Add("East");
            #endregion

            #region Room10
            room10.setDirection("w", room8);
            room10.setDirection("s", room11);
            room10.exitList.Add("West");
            room10.exitList.Add("South");
            #endregion

            #region Room11
            room11.setDirection("d", room12);
            room11.exitList.Add("Fall DOWN and out of the portal");
            #endregion

            #region Room12
            room12.setDirection("ne", room16);
            room12.setDirection("s", room15);
            room12.exitList.Add("NorthEast");
            room12.exitList.Add("South");
            #endregion

            #region Room13
            room13.setDirection("w", room3);
            room13.setDirection("s", room14);
            room13.exitList.Add("West");
            room13.exitList.Add("South");
            #endregion

            #region Room14
            room14.setDirection("n", room13);
            room14.setDirection("e", room15);
            room14.exitList.Add("North");
            room14.exitList.Add("East");
            #endregion

            #region Room15
            room15.setDirection("n", room12);
            room15.setDirection("w", room14);
            room15.exitList.Add("North");
            room15.exitList.Add("West");
            #endregion

            #region Room16
            room16.setDirection("d", room17);
            room16.setDirection("u", room12);
            room16.exitList.Add("Up");
            room16.exitList.Add("Down");
            #endregion

            #region Room17
            room17.setDirection("d", room18);
            room17.setDirection("u", room16);
            room17.exitList.Add("Up");
            room17.exitList.Add("Down");
            #endregion

            #region Room18
            room18.setDirection("d", room19);
            room18.setDirection("u", room17);
            room18.exitList.Add("Up");
            room18.exitList.Add("Down");
            #endregion

            #region Room19
            room19.setDirection("u", room18);
            room19.exitList.Add("Up");
            #endregion




            worldList.Add(room0);
            worldList.Add(room1);
            worldList.Add(room2);
            worldList.Add(room3);
            worldList.Add(room4);
            worldList.Add(room5);
            worldList.Add(room6);
            worldList.Add(room7);
            worldList.Add(room8);
            worldList.Add(room9);
            worldList.Add(room10);
            worldList.Add(room11);
            worldList.Add(room12);
            worldList.Add(room13);
            worldList.Add(room14);
            worldList.Add(room15);
            worldList.Add(room16);
            worldList.Add(room17);
            worldList.Add(room18);
            worldList.Add(room19);


            Creature wizard = new Creature();
            Item flower = new Item();
            flower.Name = "A rare crysantheum flower";
            flower.accessName.Add("crysantheum");
            flower.accessName.Add("flower");
            Item blade = new Item();
            blade.Name = "The Vorpal Blade";
            blade.accessName.Add("blade");
            wizard.Name = "Wizard Merlin";
            wizard.accessName.Add("merlin");

            room1.mobList.Add(wizard);
            room14.itemList.Add(flower);
            room19.itemList.Add(blade);

            
        }
    }
}
