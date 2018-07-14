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
        protected Random risultato;

        public virtual void Lancio()
        {
            Console.WriteLine("Lancio avvenuto!");
        }

        public virtual int Risultato() // metodo che verrà utilizzato di default dalla classe figlia Moneta; i possibili risultati saranno 0 (=croce) e 1 (=testa)
        {
            int a = risultato.Next(2);
            return a;
        }

        public virtual void Riepilogo()
        {
            List<int> risultati = new List<int>();

            foreach(OggettoAleatorio oggetto in risultati)
            {
                risultati.Add(oggetto.Risultato());
            }

        }
    }

    // classe derivata
    public class Dado : OggettoAleatorio
    {
        private int nFacce;
        
        private int NFacce
        {
            get { return nFacce; }
            set { if (nFacce > 1) nFacce = value; }
        }

        public int NumeroFacce()
        {
            string userInput;
            Console.WriteLine("Quante sono le facce di questo dado?");
            userInput = Console.ReadLine();
            nFacce = Convert.ToInt32(userInput);
            return nFacce;
        }

        public override int Risultato()
        {
            int a = risultato.Next(1, NFacce + 1);
            return a;
        }

        public override string ToString()
        {
            return "D" + nFacce + " : ";
        }
    }

    // classe derivata
    public class Moneta : OggettoAleatorio
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Moneta moneta = new Moneta();
            Dado dado = new Dado();

            char scelta;
            string userInput;

            bool again = true;
            while (again)
            {
                Console.WriteLine("Scegliere se si vuole lanciare un dado [d] o una moneta [m]: ");
                userInput = Console.ReadLine();
                scelta = Convert.ToChar(userInput);

                switch (scelta)
                {
                    case 'd':
                        Console.WriteLine("Quanti lanci si vuole effettuare?");
                        string input = Console.ReadLine();
                        int lanci = Convert.ToInt32(input);
                        for (int i = 0; i < lanci; i++)
                        {
                            dado.NumeroFacce();
                            dado.Lancio();
                            dado.Risultato();
                            Console.WriteLine(dado.ToString() + dado.Risultato());
                        }
                        dado.Riepilogo();
                        break;

                    case 'm':
                        for (int i = 0; i < 5; i++)
                        {
                            moneta.Lancio();
                            moneta.Risultato();
                            Console.WriteLine("Risultato: " + moneta.Risultato());
                        }
                        moneta.Riepilogo();
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
