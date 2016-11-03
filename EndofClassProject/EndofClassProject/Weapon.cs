using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    public class Weapon:Item
    {
        public int attackValue { get; set; }

        public Weapon()
        {
            attackValue = 0;
        }
    }
}
