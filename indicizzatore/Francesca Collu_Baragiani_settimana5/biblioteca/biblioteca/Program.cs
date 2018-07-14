using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Libro
    {
        string autore, titolo, genere;
        int annoPubblicazione, codice;

        public Libro(int codice)
        {
            this.codice = codice;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

/*
 * Si potrebbe usare questa classe per catalogare i libri all'interno di un'altra
 * classe avente come oggetti un determinato genere, autore, anno di pubblicazione.
 * In questo modo si potrebbe creare una biblioteca ordinata e facilmente monitorabile.
 */