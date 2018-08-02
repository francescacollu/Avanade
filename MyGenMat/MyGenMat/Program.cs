using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenMat
{

    class Program
    {
        //Funzione che legge la dimensione della matrice.
        static int leggiDimensione()
        {
            string userInput;
            Console.WriteLine("Inserire la dimensione della matrice quadrata: ");
            userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }

        static void Main(string[] args)
        {

            // creazione di una matrice di interi
            int dim = leggiDimensione();
            MyGenMat<double> Mint = new MyGenMat<double>(dim);

            // popolamento manuale della matrice
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    string userInput;
                    Console.WriteLine("Inserire l'elemento [{0},{1}] della matrice: ", i, j);
                    userInput = Console.ReadLine();
                    double elemento = Convert.ToDouble(userInput);
                    Mint.setElement(i, j, elemento);
                }
            }

            // stampa degli elementi
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write(Mint.getElement(i, j) + "\t");
                }
                Console.WriteLine();
            }

            // creazione di una matrice di char
            int dim2 = leggiDimensione();
            MyGenMat<char> Mchar = new MyGenMat<char>(dim2);

            // popolamento manuale della matrice
            for (int i = 0; i < dim2; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    string userInput;
                    Console.WriteLine("Inserire l'elemento [{0},{1}] della matrice: ", i, j);
                    userInput = Console.ReadLine();
                    char charachter = Convert.ToChar(userInput);
                    Mchar.setElement(i, j, charachter);
                }
            }

            // stampa degli elementi
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write(Mchar.getElement(i, j) + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
