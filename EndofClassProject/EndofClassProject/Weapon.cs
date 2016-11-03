using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
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
