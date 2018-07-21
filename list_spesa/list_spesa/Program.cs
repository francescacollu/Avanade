// Francesca Collu - esercizio sulle liste

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_spesa
{
    public class Articolo
    {
        private int codice;
        private double prezzo;

        public Articolo(int codice, double prezzo)
        {
            this.codice = codice;
            this.prezzo = prezzo;
        }

        public int Codice
        {
            get { return codice; }
            set { codice = value; }
        }
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }

        public override string ToString()
        {
            return "L'articolo " +Codice+ " costa " +Prezzo+ "euro.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Articolo> carrello = new List<Articolo>();

            Articolo articolo1 = new Articolo(0001, 12.0);
            Articolo articolo2 = new Articolo(0002, 20.5);
            Articolo articolo3 = new Articolo(0003, 0.5);

            // aggiunge l'articolo1 nella lista carrello
            carrello.Add(articolo1);

            // stampa il contenuto della lista carrello
            foreach (Articolo art in carrello)
            {
                Console.WriteLine(art.ToString());
            }

            //inserisce l'articolo2 nella prima riga della lista carrello
            carrello.Insert(0, articolo2);

            Console.WriteLine("\n");
            foreach (Articolo art in carrello)
            {
                Console.WriteLine(art.ToString());
            }

            // aggiunge l'articolo3 nella lista carrello
            carrello.Add(articolo3);

            Console.WriteLine("\n");
            foreach (Articolo art in carrello)
            {
                Console.WriteLine(art.ToString());
            }

            // rimuove l'articolo2 dalla lista carrello
            carrello.Remove(articolo2);
            Console.WriteLine("\n");
            foreach (Articolo art in carrello)
            {
                Console.WriteLine(art.ToString());
            }

            // restituisce true se esiste un articolo con una certa caratteristica
            Console.WriteLine("\nEsiste articolo con prezzo = 12.0 euro : {0}", carrello.Exists(x => x.Prezzo == 12.0));
            Console.WriteLine("\nEsiste articolo con prezzo = 20.5 euro : {0}", carrello.Exists(x => x.Prezzo == 20.5));


            // restituisce il numero di articoli presenti nella lista carrello
            Console.WriteLine("Nel carrello sono presenti " + carrello.Count + " articoli.");

            Console.ReadKey();
         }
    }
}
