using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class LinkedWorld
    {
        //public LinkedList<Room> world = new LinkedList<Room>();
        //public LinkedWorld()
        //{
        //    Room room0 = new Room();
        //    Room room1 = new Room();
        //    Room room2 = new Room();
        //    Room room3 = new Room();
        //    Room room4 = new Room();
        //    Room room5 = new Room();
        //    Room room6 = new Room();
        //    Room room7 = new Room();
        //    Room room8 = new Room();
        //    Room room9 = new Room();
        //    Room room10 = new Room();

        //    Creature goblin1 = new Creature();
        //    Creature goblin2 = new Creature();
        //    Creature goblin3 = new Creature();
        //    Creature goblin4 = new Creature();
        //    Creature goblin5 = new Creature();
        //    Creature goblin6 = new Creature();
        //    Creature goblin7 = new Creature();
        //    Creature goblin8 = new Creature();
        //    Creature goblin9 = new Creature();
        //    Creature dragon = new Creature();
        //    Creature skeleton = new Creature();
        //    Creature wolf = new Creature();

        //    //These are all the base items in our world.
        //    Item defpotion = new Item();
        //    Item atkpotion = new Item();
        //    Item healpotion = new Item();
        //    Weapon sword = new Weapon();
        //    Weapon dagger = new Weapon();
        //    Weapon staff = new Weapon();
        //    Treasure gold = new Treasure();
        //    string[] placeHolder;


        //    //Room 0 stuff. This is the bug room, where people should be sent if something wrong happens. The player should never normally see this.
        //    world.AddFirst(room0);

        //    //Room 1 stuff
        //    room1.RID = 1;
        //    room1.rName = "Entrance";
        //    healpotion.Name = "Potion of Healing";
        //    placeHolder = new string[] { "potionofhealing", "potion", "healingpotion", "potion of healing", "healing potion" };
        //    healpotion.accessName.AddRange(placeHolder);
        //    healpotion.Effect = "Heal1";
        //    room1.itemList.Add(healpotion);
        //    room1.exitList.Add("West");
        //    room1.exitList.Add("SouthWest");
        //    room1.exitList.Add("East");
        //    world.AddFirst(room1);

        //    //Room 2 stuff
        //    room2.RID = 2;
        //    room2.rName = "Dark Room";
        //    wolf.Name = "Wolf";
        //    room2.mobList.Add(wolf);
        //    placeHolder = new string[] { "potionofironskin", "potion", "ironskinpotion", "potion of ironskin", "ironskin potion" };
        //    defpotion.accessName.AddRange(placeHolder);
        //    defpotion.Name = "Ironskin Potion";
        //    defpotion.Effect = "Def1";
        //    room2.itemList.Add(defpotion);
        //    sword.Name = "Sword";
        //    sword.accessName.Add("sword");
        //    room2.itemList.Add(sword);
        //    room2.exitList.Add("North");
        //    room2.exitList.Add("West");
        //    room2.exitList.Add("South");
        //    room2.exitList.Add("SouthWest");
        //    room2.exitList.Add("NorthEast");
        //    worldList.Add(room2);

        //    //Room 3 stuff
        //    room3.RID = 3;
        //    room3.rName = "Dining Hall";
        //    goblin1.Name = "Goblin";
        //    room3.mobList.Add(goblin1);
        //    skeleton.Name = "Skeleton";
        //    room3.mobList.Add(skeleton);
        //    atkpotion.Name = "Strength Potion";
        //    placeHolder = new string[] { "potionofstrength", "potion", "strengthpotion", "potion of strength", "strength potion" };
        //    atkpotion.accessName.AddRange(placeHolder);
        //    atkpotion.Effect = "Atk1";
        //    room3.itemList.Add(atkpotion);
        //    room3.exitList.Add("North");
        //    room3.exitList.Add("East");
        //    worldList.Add(room3);

        //    //Room 4 stuff
        //    room4.RID = 4;
        //    room4.rName = "Long Hallway";
        //    goblin2.Name = "Goblin";
        //    goblin3.Name = "Goblin Archer";
        //    goblin4.Name = "Goblin Archer";
        //    room4.mobList.Add(goblin2);
        //    room4.mobList.Add(goblin3);
        //    room4.mobList.Add(goblin4);
        //    staff.Name = "Staff";
        //    staff.accessName.Add("staff");
        //    room4.itemList.Add(staff);
        //    room4.exitList.Add("East");
        //    room4.exitList.Add("West");
        //    worldList.Add(room4);

        //    //Room 5 stuff
        //    room5.RID = 5;
        //    room5.rName = "Armory";
        //    goblin5.Name = "Goblin Footsoldier";
        //    goblin6.Name = "Goblin Sergeant";
        //    goblin7.Name = "Goblin Footsoldier";
        //    room5.mobList.Add(goblin5);
        //    room5.mobList.Add(goblin6);
        //    room5.mobList.Add(goblin7);
        //    dagger.Name = "Dagger";
        //    dagger.accessName.Add("dagger");
        //    room5.itemList.Add(dagger);
        //    room5.exitList.Add("East");
        //    worldList.Add(room5);

        //    //Room 6 stuff
        //    room6.RID = 6;
        //    room6.rName = "Tallest Tower";
        //    room6.exitList.Add("West");
        //    worldList.Add(room6);

        //    //Room 7 stuff
        //    room7.RID = 7;
        //    room7.rName = "Dungeon";
        //    goblin8.Name = "Goblin Footsoldier";
        //    room7.mobList.Add(goblin8);
        //    room7.exitList.Add("North");
        //    room7.exitList.Add("West");
        //    worldList.Add(room7);

        //    //Room 8 stuff
        //    room8.RID = 8;
        //    room8.rName = "Large Holding Cell";
        //    goblin9.Name = "Goblin Footsoldier";
        //    room8.mobList.Add(goblin9);
        //    room8.exitList.Add("South");
        //    worldList.Add(room8);

        //    //Room 9 stuff
        //    room9.RID = 9;
        //    room9.rName = "Secret Cave";
        //    room9.exitList.Add("East");
        //    worldList.Add(room9);

        //    //Room 10 stuff
        //    room10.RID = 10;
        //    room10.rName = "Dragon Nest";
        //    dragon.Name = "Dragon";
        //    room10.mobList.Add(dragon);
        //    gold.accessName.Add("gold");
        //    room10.itemList.Add(gold);
        //    room10.exitList.Add("North");
        //    worldList.Add(room10);


            

        //}







    }
}
