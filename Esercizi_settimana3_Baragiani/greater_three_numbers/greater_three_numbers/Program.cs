//Esercizio 2 - settimana 3
//Francesca Collu

//Il seguente programma prende in ingresso tre numeri e ne restituisce il maggiore, calcolato mediante l'operatore ternario.

using System;

namespace ThreeNumbers
{
    class Program
    {
        static int leggiNumero()
        {
            string userInput;
            Console.WriteLine("Inserire un numero intero: ");
            userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }


        static void Main(string[] args)
        {
            //Dichiarazione delle variabili il cui valore è fornito in ingresso
            string userInput1, userInput2, userInput3;
            int a, b, c;

            //Lettura dei valori inseriti
            /*Console.WriteLine("Inserire tre numeri: ");
            userInput1 = Console.ReadLine();
            userInput2 = Console.ReadLine();
            userInput3 = Console.ReadLine();*/

            //Conversione dei valori da tipo stringa a tipo intero (a 32 bit)
            /*a = Convert.ToInt32(userInput1);
            b = Convert.ToInt32(userInput2);
            c = Convert.ToInt32(userInput3);*/

            a = leggiNumero();
            b = leggiNumero();
            c = leggiNumero();

            //Calcolo del massimo tra i primi due numeri, mediante l'operatore ternario
            int semi_max = (a > b) ? a : b;

            //Calcolo del massimo valore tra il maggiore dei primi due numeri inseriti e il terzo
            int max = (semi_max > c) ? semi_max : c;

            //Output del risultato
            Console.WriteLine("Il maggiore dei tre numeri è {0}", max);
            Console.ReadKey();
        }
    }
}