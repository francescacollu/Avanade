using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_es
{
    public class Punto
    {
        // attributi privati
        private double x;
        private double y;

        // costruttore
        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // costruttore di default: inizializza il punto nell'origine degli assi cartesiani
        public Punto()
        {
            x = 0;
            y = 0;
        }

        // proprietà
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // metodo statico per l'input da tastiera del punto
        static public Punto LeggiPunto()
        {
            double i, j;
            string input;
            Console.WriteLine("Inserisci la coordinata x del punto: ");
            input = Console.ReadLine();
            i = Convert.ToDouble(input);
            Console.WriteLine("Inserisci la coordinata y del punto: ");
            input = Console.ReadLine();
            j = Convert.ToDouble(input);

            Punto P = new Punto(i, j);
            return P;
        }

        // metodo accessorio di scrittura del punto
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Punto A = Punto.LeggiPunto();

            Console.WriteLine();
            Console.WriteLine("A = " + A.ToString());

            Console.ReadKey();

        }
    }
}