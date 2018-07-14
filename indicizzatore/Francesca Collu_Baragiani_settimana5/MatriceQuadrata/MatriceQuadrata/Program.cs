//Francesca Collu
//Esercitazione settimana 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceQuadrata
{
    //Definizione della classe
    public class MatriceQuadrata
    {
        //Attributi della classe.
        public int dimensione;
        public double[,] A;

        //Costruttore
        public MatriceQuadrata(int dim)
        {
            dimensione = dim;
            A = new double[dim, dim];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    A[i, j] = 0;
                }
            }
        }

        //Metodo per generare gli elementi pseudo-casuali all'interno della matrice
        public void MatriceRandom()
        {
            Random random = new Random();

            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    double a = random.Next(1, 100);
                    A[i, j] = a;
                }
            }

        }

        //Metodo per il popolamento manuale della matrice
        public void MatriceManuale()
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    string userInput;
                    Console.WriteLine("Inserire l'elemento [{0},{1}] della matrice: ", i, j);
                    userInput = Console.ReadLine();
                    A[i, j] = Convert.ToDouble(userInput);
                }
            }
        }

        //Metodo per la stampa della matrice
        public void StampaMatrice()
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    Console.Write("{0} \t", A[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Metodo per la moltiplicazione di uno scalare per la matrice
        public void MoltiplicazionePerScalare()
        {
            string userInput;
            Console.WriteLine("Inserire lo scalare che si vuole moltiplicare per la matrice: ");
            userInput = Console.ReadLine();
            int b = Convert.ToInt32(userInput);

            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    Console.Write("{0} \t", b*A[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Metodo di controllo della triangolarità superiore della matrice
        public bool TriangolareSup()
        {
            bool sup = true;

            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A[i, j] != 0)
                    {
                        sup = false;
                        break;
                    }
                }
            }
            return sup;
        }

        //Metodo di controllo della triangolarità inferiore della matrice
        public bool TriangolareInf()
        {
            bool inf = true;
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = dimensione-1; j > i; j--)
                {
                    if (A[i, j] != 0)
                    {
                        inf = false;
                        break;
                    }
                }
            }
            return inf;
        }

        //Metodo di controllo della diagonalità della matrice
        public bool Diagonale()
        {
            bool t = true;
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    if ((i != j) && A[i, j] != 0)
                    {
                        t = false;
                        break;
                    }
                    else
                    {
                        t = true;
                    }
                }
            }
            return t;
        }

        //Nota: si sarebbe potuto ottenere lo stesso risultato effettuando un AND tra il metodo TriangolareInf() e TriangolareSup() sopra definiti.
    }

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

        //Funzione che legge la scelta dell'utente
        static char leggiScelta1()
        {
            Console.WriteLine("Selezionare \n 1 se si vuole generare una matrice con elementi pseudo-casuali, \n 2 per popolare manualmente la matrice, \n 3 per uscire dal programma.");
            string userInput = Console.ReadLine();
            return Convert.ToChar(userInput);
        }

        static char leggiScelta2()
        {
            Console.WriteLine("Selezionare \n 1 per stampare la matrice, \n 2 per effettuare la moltiplicazione con uno scalare, \n 3 per sapere se è triangolare, \n 4 per sapere se è diagonale.");
            string userInput = Console.ReadLine();
            return Convert.ToChar(userInput);
        }

        static void Main(string[] args)
        {
            int D = leggiDimensione();
            char scelta1, scelta2;
            bool exit = false;

            //Istanziazione dell'oggetto matrice
            MatriceQuadrata matrice = new MatriceQuadrata(D);


            //Di seguito la struttura di selezione switch per la scelta delle opzioni da parte dell'utente.
            while(true)
            {
                scelta1 = leggiScelta1();
                

                switch (scelta1)
                {
                    case '1':
                        {
                                matrice.MatriceRandom();

                            scelta2 = leggiScelta2();
                            switch (scelta2)
                                {
                                    case '1':
                                        matrice.StampaMatrice();
                                        break;

                                    case '2':
                                        matrice.MoltiplicazionePerScalare();
                                        break;

                                    case '3':
                                        if (matrice.TriangolareInf() || matrice.TriangolareSup())
                                        {
                                            Console.WriteLine("True");
                                        }
                                        else Console.WriteLine("False");
                                        break;

                                    case '4':
                                        if (matrice.Diagonale())
                                        {
                                            Console.WriteLine("True");
                                        }
                                        else Console.WriteLine("False");
                                        break;

                                    default:
                                        Console.WriteLine("Non hai inserito un comando valido.");
                                        scelta2 = leggiScelta2();

                                        break;
                                }break;
                        }
                        
                    case '2':
                        {
                            matrice.MatriceManuale();
                            scelta2 = leggiScelta2();
                            switch (scelta2)
                                {
                                    case '1':
                                        matrice.StampaMatrice();
                                        break;

                                    case '2':
                                        matrice.MoltiplicazionePerScalare();
                                        break;

                                    case '3':
                                        if (matrice.TriangolareInf() || matrice.TriangolareSup())
                                        {
                                            Console.WriteLine("True");
                                        }
                                        else Console.WriteLine("False");
                                        break;

                                    case '4':
                                        if (matrice.Diagonale())
                                        {
                                            Console.WriteLine("True");
                                        }
                                        else Console.WriteLine("False");
                                        break;

                                    default:
                                        Console.WriteLine("Non hai inserito un comando valido.");
                                        scelta2 = leggiScelta2();
                                        break;
                                }break;
                        }

                    case '3':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Non hai inserito un comando valido.");
                        scelta1 = leggiScelta1();
                        break;
                }

                if (exit) break;
            }
        }
    }
}
