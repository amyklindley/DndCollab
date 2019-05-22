using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RGPGameApp.Classes
{
    public class StatLine
    {
        private Random rnd = new Random();
        private int[] StatRoll = new int[4];
        private int[] LineRoll = new int[6];
        
        public StatLine()
        {
            RollStatLine();
        }
        private int OneDice()
        {
            return rnd.Next(6) + 1;
        }

        private int StatDiceRoll()
        {
            int result;
            for (int i = 0; i < StatRoll.Length; i++)
            {
                StatRoll[i] = OneDice();
            }
            
            for (int i = 0; i < StatRoll.Length; i++)
            {
                if (StatRoll[i] == 1)
                    StatRoll[i] = OneDice();
                
            }

            Array.Sort(StatRoll);
            Array.Reverse(StatRoll);

            result = StatRoll[0] + StatRoll[1] + StatRoll[2];

            return result;
        }

        public int[] RollStatLine()
        {
            for (int i = 0; i < LineRoll.Length; i++)
            {
                LineRoll[i] = StatDiceRoll();
            }

            return LineRoll;
        }
    }
}

