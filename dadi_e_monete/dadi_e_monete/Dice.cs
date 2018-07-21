using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_and_coins
{
    public class Dice : OggettoRandom
    {
        private int nFacce;

        public Dice(int nFacce)
        {
            this.nFacce = nFacce;
        }

        public Dice()
        {
            nFacce = 6;
        }

        public int NFacce
        {
            get { return nFacce; }
            set { nFacce = value; }
        }


        // metodo statico per l'input da tastiera del numero di facce del dado che si vuole lanciare
        static public Dice LeggiDado()
        {
            int n;
            Console.WriteLine("Inserire il numero di facce del dado: ");
            string userInput = Console.ReadLine();
            n = Convert.ToInt32(userInput);

            Dice dado = new Dice(n);
            return dado;
        }

        public int Risultato()
        {
            int num = random.Next(1, nFacce + 1);
            Risultati.Add(num);
            return num;
        }

        public override void Print()
        {
            foreach(int r in Risultati)
            {
                Console.WriteLine("D" + NFacce + " : " +r);
            }
        }

    }
}
