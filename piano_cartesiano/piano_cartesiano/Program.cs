// Francesca Collu - esercitazione settimana 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piano_cartesiano
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

        // metodo accessorio di individuazione del quadrante di appartenenza del punto
        public void Quadrante()
        {
            if (x > 0 && y > 0)
                Console.WriteLine("Il punto (" + x + "," + y + ") si trova nel I quadrante.");
            else if (x > 0 && y < 0)
                Console.WriteLine("Il punto (" + x + "," + y+") si trova nel IV quadrante.");
            else if(x < 0 && y > 0)
                Console.WriteLine("Il punto (" + x + "," + y+") si trova nel II quadrante.");
            else if(x < 0 && y < 0)
                Console.WriteLine("Il punto (" + x + "," + y+") si trova nel III quadrante.");
        }

        // metodo accessorio che calcola la distanza del punto dall'origine
        public double DistanzaOrigine()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // metodo accessorio che calcola la distanza del punto dagli assi
        public void DistanzaAssi()
        {
            Console.WriteLine("La distanza del punto (" + x + "," + y + ") dall'asse X è " + Math.Abs(y) +" e dall'asse Y è " + Math.Abs(x));
        }
    }

    public class Segmento
    {
        // attributi privati
        private Punto A; // estremo del segmento
        private Punto B; // estremo del segmento

        // costruttore
        public Segmento(Punto A, Punto B)
        {
            this.A = A;
            this.B = B; 
        }

        // costruttore di default
        public Segmento()
        {
            Punto A = new Punto(0, 0);
            Punto B = new Punto(0, 0);
        }

        // metodo accessorio che calcola la lunghezza del segmento
        public double Lunghezza()
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }

        // metodo accessorio che calcola il punto medio del segmento
        public string PuntoMedio()
        {
            Punto puntoMedio = new Punto();
            puntoMedio.X = (A.X + B.X) / 2;
            puntoMedio.Y = (A.Y + B.Y) / 2;
            return puntoMedio.ToString();
        }

        // metodo accessorio che valuta la pendenza della retta passante per il segmento
        public void Pendenza()
        {
            if ((B.X - A.X) != 0)
            {
                if((B.Y - A.Y)==0)
                {
                    Console.WriteLine("Il segmento è parallelo all'asse X.");
                }
                else
                    Console.WriteLine("La pendenza del segmento è " + (B.Y - A.Y) / (B.X - A.X));
            }
            else
                Console.WriteLine("Il segmento è parallelo all'asse Y.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punto A = Punto.LeggiPunto();
            Punto B = Punto.LeggiPunto();

            Console.WriteLine();
            Console.WriteLine("A = " + A.ToString());
            Console.WriteLine("B = " + B.ToString());

            Console.WriteLine();
            A.Quadrante();
            B.Quadrante();

            Console.WriteLine();
            Console.WriteLine("La distanza del punto "+ A.ToString() + " dall'origine è " + A.DistanzaOrigine());
            Console.WriteLine("La distanza del punto " + B.ToString() + " dall'origine è " + B.DistanzaOrigine());


            Segmento segmento = new Segmento(A, B);
            Console.WriteLine();
            Console.WriteLine("La lunghezza del segmento è " + segmento.Lunghezza());
            Console.WriteLine("Il punto medio del segmento è " + segmento.PuntoMedio());
            segmento.Pendenza();

            Console.ReadKey();
        }
    }
}
