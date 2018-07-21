using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_and_coins
{
    public abstract class OggettoRandom
    {
        private List<int> risultati;
        public static Random random = new Random();

        public OggettoRandom()
        {
            risultati = new List<int>();
        }

        public List<int> Risultati
        {
            get { return risultati; }
        }

        public abstract void Print();
    }
}
