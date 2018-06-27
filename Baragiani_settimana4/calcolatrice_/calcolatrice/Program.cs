//Francesca Collu
//Esercitazione settimana 4 - esercizio 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolatrice
{
    class Program
    {
        //Questa funzione legge l'input e lo converte in un tipo double.
        static double leggiNumero()
        {
            string userInput;
            Console.WriteLine("Inserire il numero: ");
            userInput = Console.ReadLine();
            return Convert.ToDouble(userInput);
        }

        //Questa funzione legge l'input e lo converte in un tipo char.
        static char leggiOperatore()
        {
            Console.WriteLine("Selezionare il tipo di operazione che si vuole fare: \n + per l'addizione, \n - per la sottrazione" +
                "\n * per la moltiplicazione, \n / per la divisione.");
            string userInput = Console.ReadLine();
            return Convert.ToChar(userInput);
        }

        static void Main(string[] args)
        {
            double x, y, result;
            char operatore;

            while (true)
            {
                x = leggiNumero();
                y = leggiNumero();
                operatore = leggiOperatore();

                switch (operatore)
                {
                    case '+':
                        result = x + y;
                        Console.WriteLine("{0} + {1} = {2}", x, y, result);
                        break;
                    case '-':
                        result = x - y;
                        Console.WriteLine("{0} - {1} = {2}", x, y, result);
                        break;
                    case '*':
                        result = x * y;
                        Console.WriteLine("{0} * {1} = {2}", x, y, result);
                        break;
                    case '/':
                        if (y != 0)
                        {
                            result = x / y;
                            Console.WriteLine("{0} / {1} = {2}", x, y, result);
                        }
                        else if (y == 0) //Emette l'errore nel caso in cui il divisore inserito sia uguale a zero.
                        {
                            Console.WriteLine("Errore. Inserire un divisore diverso da zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Non hai inserito un operatore valido.");
                        operatore = leggiOperatore();

                        break;
                }
                Console.WriteLine("Vuoi eseguire un'altra operazione? Se desideri interrompere, digita N, altrimenti digita un numero.");
                string userIn = Console.ReadLine();
                char risposta = Convert.ToChar(userIn);

                if (risposta == 'N' || risposta == 'n')
                {
                    break;
                }

            }
            Console.ReadKey();

        }
    }
}
