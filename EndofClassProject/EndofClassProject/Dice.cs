using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    public class RandomDice
    {
        private Random _rand;

        public int Size { get; set; }
        public int Result { get; set; }
        public RandomDice()
        {
            Singleton single = Singleton.Instance;
            _rand = single.Rand;
        }

        public int rollDice(int size)
        {
            Result = _rand.Next(size + 1);
            return Result;
        }
       
        public int rollDice(Creature thing)
        {
            Result = _rand.Next(Size + 1);

           
            return Result + thing.ATK;
        }



    }
}
