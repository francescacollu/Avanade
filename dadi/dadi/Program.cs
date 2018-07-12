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
        protected Random result = new Random();

        public virtual void Lancio()
        {
            Console.WriteLine("Lancio avvenuto!");
        }

        public virtual int Risultato()
        {
            int a = result.Next(0, 2);
            return a;
        }
    }

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
            int a = result.Next(1, NFacce + 1);
            if (NFacce < 1) Console.WriteLine("Inserire un valore valido (maggiore di 1)");
            return a;
        }

        public override string ToString()
        {
            return "D" + nFacce + " : ";
        }
    }

    public class Moneta : OggettoAleatorio
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dado dado = new Dado();
            Moneta moneta = new Moneta();

            List<Dado> dadi = new List<Dado>();
            List<Moneta> monete = new List<Moneta>();

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
                            dadi.Add(dado);
                        }
                        break;

                    case 'm':
                        moneta.Lancio();
                        moneta.Risultato();
                        if (moneta.Risultato() == 0) Console.WriteLine("Moneta : croce");
                        else if (moneta.Risultato() == 1) Console.WriteLine("Moneta : testa");
                        monete.Add(moneta);
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

                Console.WriteLine("Riepilogo: \n");
                foreach(Dado dadino in dadi)
                {
                    Console.WriteLine(dado.ToString() + dado.Risultato());
                }
            }
            Console.ReadKey();
        }
    }
}
