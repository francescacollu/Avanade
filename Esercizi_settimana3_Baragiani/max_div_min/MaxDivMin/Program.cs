//Esercizio 1 - settimana 3
//Francesca Collu

/*Il seguente programma confronta due numeri dati in ingresso, restituendone il maggiore, per poi fare la divisione tra il massimo e il minimo, fornendo anche il resto della stessa.*/


using System;

namespace RatioMinMax
{
    class MaxDivMin
    {
        static void DivResto(int x, int y)
        {
            int div, resto;
            div = x / y;
            resto = x % y;
            Console.WriteLine("Il massimo tra i due numeri è {0}", x);
            Console.WriteLine("La divisione tra il massimo e il minimo è {0} con resto {1}", div, resto);
        }

        static void Main(string[] args)
        {
            //Dichiarazione delle variabili, il cui valore è fornito in ingresso
            string userInput1, userInput2;
            int intVal1, intVal2;

            //Richiesta dei valori che si vogliono assegnare
            Console.WriteLine("Inserire due numeri: ");

            //Lettura dei valori inseriti e inizializzazione delle variabili di tipo stringa
            userInput1 = Console.ReadLine();
            userInput2 = Console.ReadLine();

            //Conversione dei valori da tipo stringa a tipo intero
            intVal1 = Convert.ToInt32(userInput1);
            intVal2 = Convert.ToInt32(userInput2);

            //Calcolo del valore massimo e del valore minimo mediante l'operatore ternario (si sarebbe potuto utilizzare anche  il costrutto if-else)
            /*int max = (intVal1 > intVal2) ? intVal1 : intVal2;
            int min = (intVal1 < intVal2) ? intVal1 : intVal2;*/

            //Definizione del quoziente e del resto, mediante gli operatori aritmetici di divisione e modulo
            /*int quoz = max / min;
            int rest = max % min;*/

            if(intVal1>intVal2)
            {
                DivResto(intVal1, intVal2);
            }
            else
            {
                DivResto(intVal2, intVal1);
            }

            //Console.WriteLine("Il massimo tra i due numeri è {0}", max);
            //Console.WriteLine("La divisione tra il massimo e il minimo è {0} con resto {1}", quoz, rest);

            Console.ReadKey();
        }
    }

}
