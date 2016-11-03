using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class Container : Item
    {
        public bool isopen;
        public List<Item> inventory;

        public Container()
        {
            isopen = false;
            inventory = new List<Item>();
        }

        public void openContainer()
        {
            isopen = true;
        }
        public void closeContainer()
        {
            isopen = false;
        }

    }
}
