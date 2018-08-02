// Francesca Collu - settimana 11

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
            bool again = true;
            while (again)
            {
                Console.WriteLine("Digitare [1] per avere una matrice numerica o [2] per una matrice di caratteri alfabetici:");
                char input1 = Convert.ToChar(Console.ReadLine());
                int dim = leggiDimensione();

                if (input1 == '1')
                {
                    // creazione di una matrice di numeri
                    MyGenMat<double> Mint = new MyGenMat<double>(dim);

                    Console.WriteLine("Digitare [m] per popolare manualmente la matrice o [r] per un popolamento pseudo-casuale:");
                    char input2 = Convert.ToChar(Console.ReadLine());

                    if (input2 == 'm')
                    {
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
                        Console.WriteLine("La matrice generata è la seguente:");
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                Console.Write(Mint.getElement(i, j) + "\t");
                            }
                            Console.WriteLine();
                        }
                    }

                    else if (input2 == 'r')
                    {
                        // popolamento pseudo-random della matrice
                        Random random = new Random();
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                double elemento = random.Next(1, 101);
                                Mint.setElement(i, j, elemento);
                            }
                        }

                        // stampa degli elementi
                        Console.WriteLine("La matrice generata è la seguente:");
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                Console.Write(Mint.getElement(i, j) + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                else if (input1 == '2')
                {
                    // creazione di una matrice di char
                    MyGenMat<char> Mchar = new MyGenMat<char>(dim);

                    Console.WriteLine("Digitare [m] per popolare manualmente la matrice o [r] per un popolamento pseudo-casuale:");
                    char input2 = Convert.ToChar(Console.ReadLine());

                    if (input2 == 'm')
                    {
                        // popolamento manuale della matrice
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                string userInput;
                                Console.WriteLine("Inserire l'elemento [{0},{1}] della matrice: ", i, j);
                                userInput = Console.ReadLine();
                                char elemento = Convert.ToChar(userInput);
                                Mchar.setElement(i, j, elemento);
                            }
                        }

                        // stampa degli elementi
                        Console.WriteLine("La matrice generata è la seguente:");
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                Console.Write(Mchar.getElement(i, j) + "\t");
                            }
                            Console.WriteLine();
                        }
                    }

                    else if (input2 == 'r')
                    {
                        // popolamento pseudo-random della matrice
                        Random rnd = new Random();
                        string stringa = "qwertyuiopasdfghjklzxcvbnm";
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                int index = rnd.Next(1, stringa.Length + 1);
                                char elemento = stringa[index];
                                Mchar.setElement(i, j, elemento);
                            }
                        }

                        // stampa degli elementi
                        Console.WriteLine("La matrice generata è la seguente:");
                        for (int i = 0; i < dim; i++)
                        {
                            for (int j = 0; j < dim; j++)
                            {
                                Console.Write(Mchar.getElement(i, j) + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                Console.WriteLine("Si vuol continuare? [s] per sì, [n] per uscire.");
                char input3 = Convert.ToChar(Console.ReadLine());
                if(input3 == 's') { again = true; }
                else { break; }
            }
            
            Console.ReadKey();
        }
    }
}
