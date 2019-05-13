using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RGPGameApp.Classes
{
    public class RollingDie
    {
        private Random random;
        private int sidesCount;

        RollingDie die = new RollingDie();
        
        public RollingDie()
        {
            sidesCount = 6;
            random = new Random();
        }
        public int GetSidesCount()
        {
            return sidesCount;
        }
        public RollingDie(int sidesCount)
        {
            this.sidesCount = sidesCount;
            random = new Random();
        }
        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }
    }
}
