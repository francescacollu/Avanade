using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione17
{
    class Documento
    {
        //attributo
        private string[] righe;

        public Documento(int n)
        {
            righe = new string[n];
        }

        //indicizzatore
        public string this[int i]
        {
            get
            {
                if (i < righe.Length)
                    return righe[i];
                else return "indice non valido";
            }
            set
            {
                if (i < righe.Length)
                    righe[i] = value;
            }
        }

        //overloading indicizzatore per ricevere l'indice 
        public int this[string str]
        {
            get
            {
                for (int i = 0; i < righe.Length; i++)
                {
                    if (righe[i] == str)
                        return i;
                }
                return -1;
            }
        }

        //indicizzatore per un carattere
        public char this[int riga, int colonna]
        {
            get
            {
                if (riga < righe.Length)
                {
                    string str = righe[riga];
                    if (colonna < str.Length)
                        return str[colonna];
                }
                return '\u0000';
            }
            set
            {
                if (riga < righe.Length)
                {
                    string str = righe[riga];
                    if (colonna < str.Length)
                    {
                        righe[riga] = str.Substring(0, colonna) + value;
                        if (colonna < str.Length - 1)
                            righe[riga] += str.Substring(colonna + 1);
                    }
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Documento password = new Documento(3);
            password[0] = "prima";
            password[1] = "seconda";
            password[2] = "terza";
            Console.WriteLine(password[0]);
            int i = password["seconda"];
            Console.WriteLine("password[\"seconda\"]={0}", i);
            Console.WriteLine(password[2]); //stampa 'terza'
            password[2, 3] = 'r'; //cambia il carattere di indice 3
            Console.WriteLine(password[2]); //stampa 'terra'
            Console.ReadKey();
        }
    }
}
