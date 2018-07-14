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

            Console.WriteLine("Codice: {0} \nAutore: {1} \nTitolo: {2} \nAnno di pubblicazione: {3} " +
                "\nGenere: {4}", libro.Codice(), libro.Autore(), libro.Titolo(), libro.Anno(), libro.Genere());

            Console.ReadKey();
        }
    }
}

/*
 * Si potrebbe realizzare una nuova classe che filtri gli oggetti della classe Libro, secondo determinate
 * caratteristiche; per esempio si potrebbero individuare i libri di un certo autore, o di un certo genere,
 * o pubblicati in un certo anno (penso alla creazione di una classe Romanzo o Marquez o 1967, per restare
 * sull'esempio che ho scritto sopra).
 * In questo modo si riuscirebbe a monitorare i libri della biblioteca.
 */
