using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class World
    {

        public List<Room> worldList = new List<Room>();

        public World()
        {
            //this is gonna need to be replaced later, but for now this is okay.
            Room room0 = new Room();
            Room room1 = new Room();
            Room room2 = new Room();
            Room room3 = new Room();
            Room room4 = new Room();
            Room room5 = new Room();
            Room room6 = new Room();
            Room room7 = new Room();
            Room room8 = new Room();
            Room room9 = new Room();
            Room room10 = new Room();
            Room room11 = new Room();
            Room room12 = new Room();
            Room room13 = new Room();
            Room room14 = new Room();
            Room room15 = new Room();
            Room room16 = new Room();
            Room room17 = new Room();
            Room room18 = new Room();
            Room room19 = new Room();
            Room room20 = new Room();
            Room room21 = new Room();
            Room room22 = new Room();
            Room room23 = new Room();
            Room room24 = new Room();
            Room room25 = new Room();
            Room room26 = new Room();
            Room room27 = new Room();
            Room room28 = new Room();
            Room room29 = new Room();
            Room room30 = new Room();
            Room room31 = new Room();
            Room room32 = new Room();
            Room room33 = new Room();
            Room room34 = new Room();
            Room room35 = new Room();
            Room room36 = new Room();
            Room room37 = new Room();
            Room room38 = new Room();
            Room room39 = new Room();
            Room room40 = new Room();
            Room room41 = new Room();
            Room room42 = new Room();
            Room room43 = new Room();
            Room room44 = new Room();
            Room room45 = new Room();
            Room room46 = new Room();
            Room room47 = new Room();
            Room room48 = new Room();
            Room room49 = new Room();
            Room room50 = new Room();
            Room room51 = new Room();
            Room room52 = new Room();
            Room room53 = new Room();
            Room room54 = new Room();
            Room room55 = new Room();
            Room room56 = new Room();
            Room room57 = new Room();
            Room room58 = new Room();
            Room room59 = new Room();
            Room room60 = new Room();


            //This is the base creature in our world.
            Creature goblin1 = new Creature();
            Creature goblin2 = new Creature();
            Creature goblin3 = new Creature();
            Creature goblin4 = new Creature();
            Creature goblin5 = new Creature();
            Creature goblin6 = new Creature();
            Creature goblin7 = new Creature();
            Creature goblin8 = new Creature();
            Creature goblin9 = new Creature();
            Creature dragon = new Creature();
            Creature skeleton = new Creature();
            Creature wolf = new Creature();

            //These are all the base items in our world.
            Item defpotion = new Item();
            Item atkpotion = new Item();
            Item healpotion = new Item();
            Weapon sword = new Weapon();
            Weapon dagger = new Weapon();
            Weapon staff = new Weapon();
            Treasure gold = new Treasure();
            string[] placeHolder;


            //Room 0 stuff. This is the bug room, where people should be sent if something wrong happens. The player should never normally see this.
            worldList.Add(room0);

            //Room 1 stuff
            room1.RID = 1;
            room1.rName = "Entrance";
            healpotion.Name = "Potion of Healing";
            placeHolder = new string[] {"potionofhealing", "potion", "healingpotion", "potion of healing", "healing potion"};
            healpotion.accessName.AddRange(placeHolder);
            healpotion.Effect = "Heal1";
            room1.itemList.Add(healpotion);
            room1.exitList.Add("West");
            room1.exitList.Add("SouthWest");
            room1.exitList.Add("East");
            worldList.Add(room1);

            //Room 2 stuff
            room2.RID = 2;
            room2.rName = "Dark Room";
            wolf.Name = "Wolf";
            room2.mobList.Add(wolf);
            placeHolder = new string[] { "potionofironskin", "potion", "ironskinpotion", "potion of ironskin", "ironskin potion" };
            defpotion.accessName.AddRange(placeHolder);
            defpotion.Name = "Ironskin Potion";
            defpotion.Effect = "Def1";
            room2.itemList.Add(defpotion);
            sword.Name = "Sword";
            sword.accessName.Add("sword");
            room2.itemList.Add(sword);
            room2.exitList.Add("North");
            room2.exitList.Add("West");
            room2.exitList.Add("South");
            room2.exitList.Add("SouthWest");
            room2.exitList.Add("NorthEast");
            worldList.Add(room2);

            //Room 3 stuff
            room3.RID = 3;
            room3.rName = "Dining Hall";
            goblin1.Name = "Goblin";
            room3.mobList.Add(goblin1);
            skeleton.Name = "Skeleton";
            room3.mobList.Add(skeleton);
            atkpotion.Name = "Strength Potion";
            placeHolder = new string[] { "potionofstrength", "potion", "strengthpotion", "potion of strength", "strength potion" };
            atkpotion.accessName.AddRange(placeHolder);
            atkpotion.Effect = "Atk1";
            room3.itemList.Add(atkpotion);
            room3.exitList.Add("North");
            room3.exitList.Add("East");
            worldList.Add(room3);

            //Room 4 stuff
            room4.RID = 4;
            room4.rName = "Long Hallway";
            goblin2.Name = "Goblin";
            goblin3.Name = "Goblin Archer";
            goblin4.Name = "Goblin Archer";
            room4.mobList.Add(goblin2);
            room4.mobList.Add(goblin3);
            room4.mobList.Add(goblin4);
            staff.Name = "Staff";
            staff.accessName.Add("staff");
            room4.itemList.Add(staff);
            room4.exitList.Add("East");
            room4.exitList.Add("West");
            worldList.Add(room4);

            //Room 5 stuff
            room5.RID = 5;
            room5.rName = "Armory";
            goblin5.Name = "Goblin Footsoldier";
            goblin6.Name = "Goblin Sergeant";
            goblin7.Name = "Goblin Footsoldier";
            room5.mobList.Add(goblin5);
            room5.mobList.Add(goblin6);
            room5.mobList.Add(goblin7);
            dagger.Name = "Dagger";
            dagger.accessName.Add("dagger");
            room5.itemList.Add(dagger);
            room5.exitList.Add("East");
            worldList.Add(room5);

            //Room 6 stuff
            room6.RID = 6;
            room6.rName = "Tallest Tower";
            room6.exitList.Add("West");
            worldList.Add(room6);

            //Room 7 stuff
            room7.RID = 7;
            room7.rName = "Dungeon";
            goblin8.Name = "Goblin Footsoldier";
            room7.mobList.Add(goblin8);
            room7.exitList.Add("North");
            room7.exitList.Add("West");
            worldList.Add(room7);

            //Room 8 stuff
            room8.RID = 8;
            room8.rName = "Large Holding Cell";
            goblin9.Name = "Goblin Footsoldier";
            room8.mobList.Add(goblin9);
            room8.exitList.Add("South");
            worldList.Add(room8);

            //Room 9 stuff
            room9.RID = 9;
            room9.rName = "Secret Cave";
            room9.exitList.Add("East");
            worldList.Add(room9);

            //Room 10 stuff
            room10.RID = 10;
            room10.rName = "Dragon Nest";
            dragon.Name = "Dragon";
            room10.mobList.Add(dragon);
            gold.accessName.Add("gold");
            room10.itemList.Add(gold);
            room10.exitList.Add("North");
            worldList.Add(room10);


            room11.RID = 11;
            room11.exitList.Add("North");
            room11.exitList.Add("West");
            worldList.Add(room11);
            room12.RID = 12;
            room12.exitList.Add("East");
            room12.exitList.Add("West");
            room12.exitList.Add("SouthWest");
            worldList.Add(room12);
            room13.RID = 13;
            room13.exitList.Add("East");
            room13.exitList.Add("West");
            worldList.Add(room13);
            room14.RID = 14;
            room14.exitList.Add("West");
            room14.exitList.Add("NorthEast");
            worldList.Add(room14);
            room15.RID = 15;
            room15.exitList.Add("East");
            worldList.Add(room15);
            room16.RID = 16;
            room16.exitList.Add("East");
            room16.exitList.Add("West");
            worldList.Add(room16);
            room17.RID = 17;
            room17.exitList.Add("North");
            room17.exitList.Add("West");
            room17.exitList.Add("South");
            room17.exitList.Add("East");
            room17.exitList.Add("NorthWest");
            worldList.Add(room17);
            room18.RID = 18;
            room18.exitList.Add("North");
            room18.exitList.Add("East");
            worldList.Add(room18);
            room19.RID = 19;
            room19.exitList.Add("South");
            room19.exitList.Add("NorthEast");
            worldList.Add(room19);
            room20.RID = 20;
            room20.exitList.Add("North");
            room20.exitList.Add("East");
            worldList.Add(room20);
            room21.RID = 21;
            room21.exitList.Add("SouthWest");
            worldList.Add(room21);
            //room22.RID = 22;
            //room22.exitList.Add("Placeholder");
            //worldList.Add(room22);
            room23.RID = 23;
            room23.exitList.Add("East");
            room23.exitList.Add("West");
            worldList.Add(room23);
            room24.RID = 24;
            room24.exitList.Add("East");
            room24.exitList.Add("West");
            room24.exitList.Add("South");
            worldList.Add(room24);
            room25.RID = 25;
            room25.exitList.Add("North");
            room25.exitList.Add("West");
            room25.exitList.Add("SouthWest");
            room25.exitList.Add("SouthEast");
            worldList.Add(room25);
            room26.RID = 26;
            room26.exitList.Add("North");
            room26.exitList.Add("East");
            worldList.Add(room26);
            room27.RID = 27;
            room27.exitList.Add("West");
            room27.exitList.Add("South");
            room27.exitList.Add("NorthEast");
            worldList.Add(room27);
            room28.RID = 28;
            room28.exitList.Add("West");
            room28.exitList.Add("NorthWest");
            worldList.Add(room28);
            room29.RID = 29;
            room29.exitList.Add("South");
            worldList.Add(room29);
            room30.RID = 30;
            room30.exitList.Add("East");
            worldList.Add(room30);
            room31.RID = 31;
            room31.exitList.Add("East");
            room31.exitList.Add("West");
            worldList.Add(room31);
            room32.RID = 32;
            room32.exitList.Add("North");
            room32.exitList.Add("East");
            room32.exitList.Add("South");
            worldList.Add(room32);
            room33.RID = 33;
            room33.exitList.Add("North");
            room33.exitList.Add("SouthEast");
            room33.exitList.Add("SouthWest");
            worldList.Add(room33);
            room34.RID = 34;
            room34.exitList.Add("NorthEast");
            room34.exitList.Add("SouthEast");
            worldList.Add(room34);
            room35.RID = 35;
            room35.exitList.Add("NorthWest");
            room35.exitList.Add("SouthWest");
            worldList.Add(room35);
            room36.RID = 36;
            room36.exitList.Add("West");
            room36.exitList.Add("South");
            room36.exitList.Add("NorthEast");
            worldList.Add(room36);
            room37.RID = 37;
            room37.exitList.Add("North");
            room37.exitList.Add("West");
            room37.exitList.Add("SouthWest");
            worldList.Add(room37);
            room38.RID = 38;
            room38.exitList.Add("East");
            room38.exitList.Add("South");
            room38.exitList.Add("SouthEast");
            worldList.Add(room38);
            room39.RID = 39;
            room39.exitList.Add("North");
            room39.exitList.Add("East");
            room39.exitList.Add("NorthEast");
            worldList.Add(room39);
            room40.RID = 40;
            room40.exitList.Add("West");
            room40.exitList.Add("NorthWest");
            worldList.Add(room40);
            room41.RID = 41;
            room41.exitList.Add("North");
            room41.exitList.Add("South");
            worldList.Add(room41);
            room42.RID = 42;
            room42.exitList.Add("West");
            room42.exitList.Add("South");
            worldList.Add(room42);
            room43.RID = 43;
            room43.exitList.Add("North");
            room43.exitList.Add("East");
            room43.exitList.Add("West");
            worldList.Add(room43);
            room44.RID = 44;
            room44.exitList.Add("North");
            room44.exitList.Add("East");
            worldList.Add(room44);
            room45.RID = 45;
            room45.exitList.Add("South");
            worldList.Add(room45);
            room46.RID = 46;
            room46.exitList.Add("North");
            room46.exitList.Add("South");
            worldList.Add(room46);
            room47.RID = 47;
            room47.exitList.Add("South");
            room47.exitList.Add("NorthWest");
            room47.exitList.Add("NorthEast");
            worldList.Add(room47);
            room48.RID = 48;
            room48.exitList.Add("East");
            room48.exitList.Add("West");
            room48.exitList.Add("NorthWest");
            room48.exitList.Add("SouthWest");
            worldList.Add(room48);
            room49.RID = 49;
            room49.exitList.Add("East");
            room49.exitList.Add("NorthEast");
            room49.exitList.Add("SouthEast");
            worldList.Add(room49);
            room50.RID = 50;
            room50.exitList.Add("North");
            room50.exitList.Add("East");
            room50.exitList.Add("SouthWest");
            room50.exitList.Add("SouthEast");
            worldList.Add(room50);
            room51.RID = 51;
            room51.exitList.Add("West");
            worldList.Add(room51);
            room52.RID = 52;
            room52.exitList.Add("South");
            worldList.Add(room52);
            room53.RID = 53;
            room53.exitList.Add("East");
            room53.exitList.Add("West");
            worldList.Add(room53);
            room54.RID = 54;
            room54.exitList.Add("North");
            room54.exitList.Add("West");
            worldList.Add(room54);
            room55.RID = 55;
            room55.exitList.Add("West");
            room55.exitList.Add("South");
            worldList.Add(room55);




        }
        public void RemoveMonster()
        {

        }


    }
}
