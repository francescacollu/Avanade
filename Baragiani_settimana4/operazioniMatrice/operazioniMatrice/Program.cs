//Francesca Collu
//Esercitazione settimana 4 - esercizio 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operazioniMatrice
{
    class Program
    {
        //Funzione che legge gli elementi della matrice.
        static double leggiElemento()
        {
            string userInput;
            Console.WriteLine("Inserire l'elemento della matrice (ordinamento per righe): ");
            userInput = Console.ReadLine();
            return Convert.ToDouble(userInput);
        }

        //Funzione che legge la dimensione della matrice.
        static int leggiDimensione()
        {
            string userInput;
            Console.WriteLine("Inserire la dimensione della matrice quadrata: ");
            userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }

        //Funzione che legge il valore dello scalare che si vuole moltiplicare per la matrice.
        static double leggiNumero()
        {
            string userInput;
            Console.WriteLine("Inserire il numero che si vuole moltiplicare per la matrice: ");
            userInput = Console.ReadLine();
            return Convert.ToDouble(userInput);
        }

        //Stampa della matrice
        static void stampaMatrice(double[,] A, int n)
        {
            Console.Write("La matrice inserita è la seguente:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.Write("\n");
            }
        }

        //Somma di tutti gli elementi della diagonale secondaria della matrice
        static void sommaDiagSec(double[,] A, int n)
        {
            double somma = 0;
            for (int i = 0; i < n; i++)
            {
                somma += A[i, n - 1 - i];
            }
            Console.WriteLine("La somma degli elementi della diagonale secondaria è {0}", somma); ;
        }

        //Funzione che calcola e stampa il prodotto di uno scalare per una matrice.
        static void prodScalareMatrice(double a, double[,] A, int n)
        {
            //Calcolo del prodotto tra lo scalare e la matrice scelti.
            double[,] prodotto = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    prodotto[i, j] = a * A[i, j];
                }
            }

            //Stampa del prodotto.
            Console.WriteLine("Il prodotto tra {0} e la matrice inserita è il seguente:", a);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", prodotto[i, j]);
                }
                Console.Write("\n");
            }
        }



        static void Main(string[] args)
        {

            //Dichiarazione della matrice
            int i, j;
            int n;
            n = leggiDimensione();
            double[,] matrice = new double[n, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    matrice[i, j] = leggiElemento();
                }
            }

            //Stampa della matrice
            stampaMatrice(matrice, n);

            //Somma di tutti gli elementi della diagonale secondaria della matrice
            sommaDiagSec(matrice, n);

            //Prodotto di uno scalare per la matrice.
            double a = leggiNumero();
            prodScalareMatrice(a, matrice, n);

            Console.ReadKey();
        }
    }
}
