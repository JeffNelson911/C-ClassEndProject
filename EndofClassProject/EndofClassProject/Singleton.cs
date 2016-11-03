using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class Singleton
    {
        private static Singleton instance;
        private Random _rand;
        public Random Rand
        {
            get { return _rand; }
        }
        private Singleton()
        {

            _rand = new Random((int)DateTime.Now.Ticks & 0x0A60FFFF);

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
