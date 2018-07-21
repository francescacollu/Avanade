using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioFilesMultipli
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("inserisci la lunghezza del vettore: ");
            n = int.Parse(Console.ReadLine());
            int[] vett = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("dammi un elemento del vettore: ");
                vett[i] = int.Parse(Console.ReadLine());
            }
            Vettore ogVettore = new Vettore(vett, n);
            Console.WriteLine("il vettore ordinato è: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ogVettore.ordina()[i]);
            }
            Console.WriteLine("L'elemento massimo del vettore è: " + ogVettore.calcolaMax());
            Console.WriteLine("L'elemento minimo del vettore è: " + ogVettore.calcolaMin());

            Console.ReadLine();
        }
    }
}
