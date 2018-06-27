//Francesca Collu
//Esercitazione settimana 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Libro
    {
        //dichiarazione attributi
        string autore, titolo, genere;
        int annoPubblicazione, codice;

        //costruttore
        public Libro(int codice, string autore, string titolo, int annoPubblicazione, string genere)
        {
            this.codice = codice;
            this.autore = autore;
            this.titolo = titolo;
            this.annoPubblicazione = annoPubblicazione;
            this.genere = genere;
        }

        //metodi
        public int Codice()
        {
            return codice;
        }

        public string Autore()
        {
            return autore;
        }

        public string Titolo()
        {
            return titolo;
        }

        public int Anno()
        {
            return annoPubblicazione;
        }

        public string Genere()
        {
            return genere;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro(1234, "Gabriel Garcia Marquez", "Cent'anni di solitudine", 1967, "romanzo");

            Console.WriteLine("Codice: {0} \n Autore: {1} \n Titolo: {2} \n Anno di pubblicazione: {3} " +
                "\n Genere: {4}", libro.Codice(), libro.Autore(), libro.Titolo(), libro.Anno(), libro.Genere());

            Console.ReadKey();
        }
    }
}

/*
 * Si potrebbe usare questa classe per catalogare i libri all'interno di un'altra
 * classe avente come oggetti un determinato genere, autore, anno di pubblicazione.
 * In questo modo si potrebbe creare una biblioteca ordinata e facilmente monitorabile.
 */