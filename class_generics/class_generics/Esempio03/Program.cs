using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio03
{
    class Tester
    {
        static void Main(string[] args)
        {

            //creo un vettore di interi
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //aggiungo 5 elementi 
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }

            //stampo gli elementi
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }

            Console.WriteLine();

            //creao un vettore di char
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            //aggiungo 5 caratteri
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            //stampo i caratteri
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
