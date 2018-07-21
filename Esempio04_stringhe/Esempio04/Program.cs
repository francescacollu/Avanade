using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio04
{
    class Program
    {
        public static void Main()
        {
            // Creazione della tabella Hash
            //
            Hashtable openWith = new Hashtable();

            // aggiungo diversi elementi di coppia chiave-valore (la chiave deve essere sempre univoca il valore no)
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // Con la tecnica try catch controllo se una chiave è già stata assegnata
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("Un elemento con la chiave = \"txt\" esiste già!!!.");
            }

            // Posso accedere al valore di un elemento dalla sua chiave
            Console.WriteLine("Per la chiave = \"rtf\", il valore è = {0}.", openWith["rtf"]);

            // Posso cambiare il valore di riferimento di una chiave
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("Per la chiave = \"rtf\", il nuovo valore è = {0}.", openWith["rtf"]);

            // Se una chiave non esiste la posso creare inizializzandola
            openWith["doc"] = "winword.exe";

            // Se una chiave è presente o non lo è posso fare operazioni in conseguenza
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Ho creato la chiave ed il suo valore associato: = \"ht\": {0}", openWith["ht"]);
            }

            // Foreach per le tabelle hash lavora con le coppie chiavi valore
            Console.WriteLine();
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Chiave: = {0}, Valore: = {1}", de.Key, de.Value);
            }

            // Con la proprietà Values posso leggere solo i valori di una tabella hash
            ICollection valueColl = openWith.Values;

            // Utilizzo l'indicizzatore valueColl per scandire le stringhe dei valori
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // La medesima operazione è possibile anche con le chiavi
            ICollection keyColl = openWith.Keys;

            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Il metodo per rimuovere una coppia chiave valore, la rimozione è possibile solo dalla chiave
            Console.WriteLine("\nRimuovo la chiave; (\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" non è stata trovata.");
            }

            Console.ReadKey();
        }
    }
}
