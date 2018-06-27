//Francesca Collu
//Esercitazione settimana 4 - esercizio 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomVector
{
    class Program
    {
        //Funzione che legge la dimensione del vettore.
        static int leggiDimensione()
        {
            string userInput;
            Console.WriteLine("Inserire la dimensione del vettore: ");
            userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }

        //Funzione che calcola la media degli elementi del vettore.
        static void media(int [] A, int n)
        {
            double media;
            double somma = 0;

            foreach (int k in A)
            {
                somma += k;
            }
            media = somma / n;
            Console.WriteLine("La media è: {0}", media);
        }

        //Funzione che conta gli elementi pari e quelli dispari.
        static void pariDispari(int [] A)
        {
            int numPari = 0;
            int numDispari = 0;
            foreach (int k in A)
            {
                if (k % 2 == 0)
                {
                    ++numPari;
                }
                else
                {
                    ++numDispari;
                }
            }

            Console.WriteLine("Questo vettore contiene {0} numeri pari e {1} numeri dispari", numPari, numDispari);
        }

        //Funzione che calcola il massimo tra gli elementi del vettore pseudo-casuale.
        static void max(int[] A, int n)
        {
            int max = (A[0] > A[1]) ? A[0] : A[1];
            for (int k = 1; k < n; k++)
            {
                max = (max > A[k]) ? max : A[k];
            }
            Console.WriteLine("Il massimo è {0}", max);
        }

        //Funzione che calcola il minimo tra gli elementi del vettore pseudo-casuale.
        static void min(int[] A, int n)
        {
            int min = (A[0] < A[1]) ? A[0] : A[1];
            for (int k = 1; k < n; k++)
            {
                min = (min < A[k]) ? min : A[k];
            }
            Console.WriteLine("Il minimo è {0}", min);
        }

        static void Main(string[] args)
        {
            int n;
            n = leggiDimensione();

            //Dichiarazione e stampa del vettore pseudo-casuale.
            int[] randomArray = new int[n];

            Random rand = new Random();
            Console.Write("[\t");
            for (int i = 0; i < n; i++)
            {
                int num = rand.Next(1, 100);
                randomArray[i] = num;
                Console.Write("{0},\t", num);
            }
            Console.WriteLine("]");

            //Calcolo media.
            media(randomArray, n);

            //Conteggio degli elementi pari e di quelli dispari.
            pariDispari(randomArray);

            //Calcolo dell'elemento massimo.
            max(randomArray, n);

            //Calcolo dell'elemento minimo.
            min(randomArray, n);

            Console.ReadKey();
        }
    }
}
