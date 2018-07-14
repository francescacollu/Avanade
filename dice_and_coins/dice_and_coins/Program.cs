// Francesca Collu - settimana 8
// Versione della soluzione senza l'utilizzo della classe astratta.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_and_coins
{
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

        Random random = new Random();
        public int Risultato()
        {
            return random.Next(0, nFacce+1);
        }

    }

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
            List<int> risultati = new List<int>();
            
            int a;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Scegliere se si vuole lanciare uno o più dadi [d] o una moneta [m]: ");
                string userInput = Console.ReadLine();
                char scelta = Convert.ToChar(userInput);

                switch (scelta)
                {
                    case 'd':
                        bool rolling = true;
                        while (rolling)
                        {
                            Console.WriteLine("Quanti dadi si vogliono lanciare?");
                            string inputD = Console.ReadLine();
                            int numD = Convert.ToInt32(inputD);

                            Dado dado = Dado.LeggiDado();
                            int roll = NumeroLanci();
                            //Console.Clear();
                            for (int i = 0; i < roll; i++)
                            {
                                a = dado.Risultato();
                                Console.WriteLine(a);
                                risultati.Add(a);
                            }
                            
                            Console.WriteLine("Vuoi continuare? [s] per sì, [n] per no.");
                            userInput = Console.ReadLine();
                            char rD = Convert.ToChar(userInput);
                            if (rD == 's') { rolling = true; }
                            else
                            {
                                rolling = false;
                                Console.WriteLine(".");
                            }

                            Console.WriteLine("Riepilogo dei lanci effettuati: \n");
                            foreach (int r in risultati)
                            {
                                Console.WriteLine("D" + dado.NFacce + " : " + r);
                            }
                        }
                        break;

                    case 'm':
                        Coins coin = new Coins();
                        int toss = NumeroLanci();
                        Console.Clear();
                        for (int i = 0; i < toss; i++)
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
                        break;
                }
                Console.WriteLine("Vuoi continuare? [s] per sì, [n] per no.");
                userInput = Console.ReadLine();
                char risposta = Convert.ToChar(userInput);
                if (risposta == 's') { again = true; }
                else
                {
                    again = false;
                    Console.WriteLine("Premere un tasto per uscire.");
                }
            }

            Console.ReadKey();
        }
    }
}
