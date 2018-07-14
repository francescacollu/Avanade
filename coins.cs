using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coins
{
    public class Coins
    {
        Random random = new Random();

        public int Risultato()
        {
            return random.Next(0, 2);
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
            Coins coin = new Coins();
            List<int> risultati = new List<int>();

            int l = NumeroLanci();
            int a;
            Console.Clear();
            for (int i=0; i<l; i++)
            {
                a = coin.Risultato();
                //Console.WriteLine(a);
                risultati.Add(a);
            }

            Console.WriteLine("Riepilogo: \n");
            foreach (int r in risultati)
            {
                if (r == 0) { Console.WriteLine("M : croce"); }
                else { Console.WriteLine("M : testa"); }
            }

            Console.ReadKey();
        }
    }
}
