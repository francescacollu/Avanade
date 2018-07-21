using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_and_coins
{
    public class Coins : OggettoRandom
    {
        public int Risultato()
        {
            int a = random.Next(0, 2);
            Risultati.Add(a);
            return a;
        }

        public override void Print()
        {
            foreach(int r in Risultati)
            {
                if (r==0) { Console.WriteLine("M : croce"); }
                else { Console.WriteLine("M : testa"); }
            }
            
        }
    }
}
