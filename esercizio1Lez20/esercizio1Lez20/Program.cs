using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio1Lez20
{
    interface ICalcolatrice
    {
        double Addizione();
        double Sottrazione();
        double Moltiplicazione();
        double Divisione();
        double RadiceQuadrata();
    }

    class Numero
    {
        public double n;

        public Numero()
        {
            this.n = n;
        }

        public double N { get { return n; } }
    }

    class Operazioni: Numero, ICalcolatrice
    {
        Numero n2 = new Numero();
        public double Addizione()
        {
            return n + n2.N;
        }

        public double Sottrazione()
        {
            return n - n2.N;
        }

        public double Moltiplicazione()
        {
            return n * n2.N;
        }

        public double Divisione()
        {
            return n / n2.N;
        }

        public double RadiceQuadrata()
        {
            return Math.Sqrt(n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numero a = new Numero();
            Numero b = new Numero();

            Console.WriteLine("{0}", a.Addizione());

            Console.WriteLine
        }
    }
}
