using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione17
{
    public class NumeroComplesso
    {
        private double re;
        private double im;

        //costruttore
        public NumeroComplesso(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        //costruttore di default
        public NumeroComplesso()
        {
            re = 0;
            im = 0;
        }

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        //USARE ANCHE PER L'ESERCITAZIONE
        public override string ToString()
        {
            return re + "+i" + im;
        }

        //overload dell'operatore + per somma di due numeri complessi
        public static NumeroComplesso operator +(NumeroComplesso z1, NumeroComplesso z2)
        {
            NumeroComplesso s = new NumeroComplesso();
            s.Re = z1.Re + z2.Re;
            s.Im = z1.Im + z2.Im;
            return s;
        }

        //overload dell'operatore + per la somma di un double con un complesso
        public static NumeroComplesso operator +(double n, NumeroComplesso z)
        {
            NumeroComplesso s = new NumeroComplesso();
            s.Re = n + z.Re;
            s.Im = z.Im;
            return s;
        }

        public static NumeroComplesso operator +(NumeroComplesso z, double n)
        {
            return n + z;
        }

        public static bool operator ==(NumeroComplesso z1, NumeroComplesso z2)
        {
            return (z1.Re == z2.Im) && (z1.Re == z2.Im);
        }

        public static bool operator !=(NumeroComplesso z1, NumeroComplesso z2)
        {
            return !(z1 == z2);
        }

        public static NumeroComplesso operator *(NumeroComplesso z1, NumeroComplesso z2)
        {
            NumeroComplesso p = new NumeroComplesso();
            p.Re = z1.Re * z2.Re - z1.Im * z2.Im;
            p.Im = z1.Re * z2.Im + z2.Re * z1.Im;
            return p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplesso z1 = new NumeroComplesso(2, 5);
            NumeroComplesso z2 = new NumeroComplesso(3, 4);
            NumeroComplesso p = new NumeroComplesso();

            Console.WriteLine("z1 vale: " + z1.ToString());
            Console.WriteLine("z2 vale: " + z2.ToString());
            p = z1 * z2;
            Console.WriteLine("Il prodotto tra i due vale: " + p.ToString());

            Console.ReadKey();
        }
    }
}
