// Francesca Collu - settimana 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace string_searcher
{
    class Program
    {
        static void Main(string[] args)
        {
            // richiesta di inserimento del percorso
            Console.WriteLine("Inserire il percorso in cui si trova il file di testo che si vuole leggere: ");
            string path = Console.ReadLine();

            // verifiche del percorso
            if (File.Exists(path))
            {
                Console.WriteLine("\n" +path + " è un file");
            }
            else if (Directory.Exists(path))
            {
                Console.WriteLine("\n" + path + " è una cartella");
            }
            else
            {
                Console.WriteLine("\n{0} il percorso non è valido.", path);
            }


            // se il file non esiste si esegue la creazione e il popolamento
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Lorem");
                    sw.WriteLine("ipsum");
                    sw.WriteLine("dolor");
                }
            }

            // lettura del file
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            // inserimento della stringa ricercata e ricerca, con segnalazione del numero di righe in cui si trova tale stringa.
            Console.WriteLine("\nInserire la stringa che si vuole cercare: ");
            string input = Console.ReadLine();
            string line;
            List<int> counter = new List<int>();
            int i = 1;

            using (StreamReader sr = File.OpenText(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(input))
                    {
                        counter.Add(i);
                    }
                    i++;
                }
                if(counter.Count == 0)
                {
                    Console.WriteLine("\nIl documento non contiene la stringa ricercata.");
                }
                else if (counter.Count == 1)
                {
                    foreach (int j in counter)
                    {
                        Console.WriteLine("\nLa stringa '" + input + "' è contenuta nel documento " + counter.Count + " volta nella riga " + j + ".");
                    }
                }
                else
                {
                    Console.WriteLine("\nLa stringa '" + input + "' è contenuta nel documento " +counter.Count+ " volte, nelle seguenti righe: ");
                    foreach(int j in counter)
                    {
                        Console.WriteLine(j);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
