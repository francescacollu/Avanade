// Francesca Collu - settimana 8
// Uso della classe astratta che rappresenta i comportamenti comuni degli oggetti dadi e moneta

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadi
{
    public abstract class OggettoAleatorio
    {
        protected List<int> risultati;

        // metodo che verrà utilizzato di default dalla classe figlia Moneta; 
        // verrà invece sovrascritto dalla classe Dado.
        Random rdm = new Random();
        public virtual int Risultato() 
        {
            int a = rdm.Next(0, 2);
            return a;
        }

    }

    // classe derivata
    public class Dado : OggettoAleatorio
    {
        private int nFacce;

        public Dado(int nFacce)
        {
            this.nFacce = nFacce;
            risultati = new List<int>();

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

        public List<int> Risultati
        {
            get { return risultati; }
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
        public override int Risultato()
        {
            int num = random.Next(1, nFacce+1);
            Risultati.Add(num);
            return num;
        }

    }

    // classe derivata
    public class Moneta : OggettoAleatorio
    {
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
                List<Dado> dadi = new List<Dado>();

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
                            {
                                Console.WriteLine("Premere [L] per lanciare i dadi o [R] per il riepilogo dei lanci effettuati: ");
                                string inputD1 = Console.ReadLine();
                                char lancio_riep = Convert.ToChar(inputD1);

                                if (lancio_riep == 'L')
                                {
                                    bool rolling = true;
                                    while (rolling)
                                    {
                                        Console.WriteLine("Quanti dadi si vogliono lanciare?");
                                        string inputD = Console.ReadLine();
                                        int numD = Convert.ToInt32(inputD);
                                        if (numD == 0) { break; }

                                        for (int j = 0; j < numD; j++)
                                        {
                                            Dado dado = Dado.LeggiDado();
                                            dadi.Add(dado);

                                            int roll = NumeroLanci();
                                            for (int i = 0; i < roll; i++)
                                            {
                                                a = dado.Risultato();
                                                Console.WriteLine(a);
                                            }

                                        }

                                        Console.WriteLine("Si vuole visualizzare il riepilogo? [s] o [n]");
                                        string inputD2 = Console.ReadLine();
                                        int rispostaD2 = Convert.ToChar(inputD2);
                                        if (rispostaD2 == 's')
                                        {
                                            Console.WriteLine("Riepilogo dei lanci effettuati: \n");
                                            foreach (Dado d in dadi)
                                            {
                                                foreach (int r in d.Risultati)
                                                {
                                                    Console.WriteLine("D" + d.NFacce + " : " + r);
                                                }
                                            }
                                        }
                                        else { break; }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Riepilogo dei lanci effettuati: \n");
                                    foreach (Dado d in dadi)
                                    {
                                        foreach (int r in d.Risultati)
                                        {
                                            Console.WriteLine("D" + d.NFacce + " : " + r);
                                        }
                                    }
                                }
                            }
                            break;

                        case 'm':
                            {
                                Console.WriteLine("Premere [L] per tirare la moneta o [R] per il riepilogo del lancio effettuato: ");
                                string inputM1 = Console.ReadLine();
                                char tiro_riep = Convert.ToChar(inputM1);

                                if (tiro_riep == 'L')
                                {
                                    Moneta coin = new Moneta();
                                    int toss = NumeroLanci();
                                    Console.Clear();
                                    for (int i = 0; i < toss; i++)
                                    {
                                        a = coin.Risultato();
                                        //Console.WriteLine(a);
                                        risultati.Add(a);
                                    }
                                    Console.WriteLine("Si vuole visualizzare il riepilogo? [s] o [n]");
                                    string inputM2 = Console.ReadLine();
                                    int rispostaM2 = Convert.ToChar(inputM2);
                                    if (rispostaM2 == 's')
                                    {
                                        Console.WriteLine("Riepilogo: \n");
                                        foreach (int r in risultati)
                                        {
                                            if (r == 0) { Console.WriteLine("M : croce"); }
                                            else { Console.WriteLine("M : testa"); }
                                        }
                                    }
                                    else { break; }
                                }
                                else
                                {
                                    Console.WriteLine("Riepilogo: \n");
                                    foreach (int r in risultati)
                                    {
                                        if (r == 0) { Console.WriteLine("M : croce"); }
                                        else { Console.WriteLine("M : testa"); }
                                    }
                                }
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
