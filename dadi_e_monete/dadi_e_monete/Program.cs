// Francesca Collu - settimana 8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_and_coins
{
    public class Coins
    {
        Random random = new Random();

        public int Risultato()
        {
            return random.Next(0, 2);
        }

    }

    public class Dado
    {
        private int nFacce;

        public Dado(int nFacce)
        {
            this.nFacce = nFacce;
        }

        public Dado()
        {
            nFacce = 6;
        }

        public int NFacce
        {
            get { return nFacce; }
            set { nFacce = value; }
        }

        // metodo statico per l'input da tastiera del numero di facce del dado che si vuole lanciare
        static public Dado LeggiDado()
        {
            int n;
            Console.WriteLine("Inserire il numero di facce del dado: ");
            string userInput = Console.ReadLine();
            n = Convert.ToInt32(userInput);

            Dado dado = new Dado(n);
            return dado;
        }

        public void Lancio()
        {
            Console.WriteLine("Lancio avvenuto!");
        }

        Random random = new Random();
        public int Risultato()
        {
            return random.Next(0, nFacce + 1);
        }

    }

    class Program
    {
        static int NumeroLanci()
        {
            Console.WriteLine("Inserire il numero dei lanci che si vuole effettuare: ");
            string userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }

        static void Main(string[] args)
        {
            List<int> risultati = new List<int>();

            Dado dado = Dado.LeggiDado();
            int l = NumeroLanci();
            int a;
            Console.Clear();
            for (int i = 0; i < l; i++)
            {
                a = dado.Risultato();
                Console.WriteLine(a);
                risultati.Add(a);
            }

            Console.WriteLine("Riepilogo dei lanci effettuati: \n");
            foreach (int r in risultati)
            {
                Console.WriteLine("D" + dado.NFacce + " : " + r);
            }

            Console.ReadKey();
        }
    }
}
