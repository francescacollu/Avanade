//Esercizio 3 - settimana 3
//Francesca Collu

/*Il seguente programma testa se un numero è sia pari che multiplo di tre. Per farlo,
 fa uso di due funzioni: 'Pari', che restituisce 'true' se il numero inserito è pari;
 'MultiploTre', che restituisce 'true' se il numero inserito è multiplo di tre.*/

using System;

namespace EvenOdd
{

    class Program
    {
        //Definizione della funzione Pari: prende in ingresso un intero e restituisce un booleano
        static bool Multipli(int x, int y)
        {
            int r = x % y;
            return r == 0;
        }

        //Definizione della funzione MultiploTre: prende in ingresso un intero e restituisce un booleano
        /*static bool MultiploTre(int x)
        {
            int r = x % 3;
            return r == 0;
        }*/

        static void Main(string[] args)
        {
            //Dichiarazione delle variabili, il cui valore è fornito in ingresso
            string userInput1, userInput2, userInput3, userInput4;
            int a1, b1, a2, b2;

            //Lettura del valore inserito da tastiera
            Console.WriteLine("Inserire un numero: ");
            userInput1 = Console.ReadLine();

            Console.WriteLine("Inserire il divisore: ");
            userInput2 = Console.ReadLine();

            Console.WriteLine("Inserire il numero: ");
            userInput3 = Console.ReadLine();

            Console.WriteLine("Inserire il divisore: ");
            userInput4 = Console.ReadLine();

            //Conversione del valore da tipo stringa a tipo intero (a 32 bit)
            a1 = Convert.ToInt32(userInput1);
            b1 = Convert.ToInt32(userInput2);

            a2 = Convert.ToInt32(userInput3);
            b2 = Convert.ToInt32(userInput4);


            /*Se la condizione dell'if è 'true', cioè se entrambe (&&) le funzioni sopra
            definite restituiscono 'true', il programma eseguirà l'istruzione scritta
            all'interno del blocco.*/
            if (Multipli(a1, b1) && Multipli(a2, b2))
            {
                Console.WriteLine("Il numero è pari e multiplo di tre.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Il numero inserito non è contemporaneamente pari e multiplo di tre.");
                Console.ReadKey();
            }
        }
    }
}