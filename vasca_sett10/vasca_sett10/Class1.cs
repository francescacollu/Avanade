// Francesca Collu - settimana 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vasca_sett10
{
    // creazione di un'eccezione personalizzata
    public class LivelloMaxRaggiunto : Exception
    {
        public LivelloMaxRaggiunto(string message) : base(message)
        {
        }
    }

    // creazione di un'eccezione personalizzata
    public class LivelloMinRaggiunto : Exception
    {
        public LivelloMinRaggiunto(string message) : base(message)
        {
        }
    }

    public class Vasca
    {
        private Stack<int> acqua;
        private int min;
        private int max;

        public Vasca()
        {
            acqua = new Stack<int>();
        }

        public Stack<int> Acqua
        {
            get { return acqua; }
            set { acqua = value; }
        }

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public void LeggiLivelli()
        {
            Console.WriteLine("Inserire il livello minimo di riempimento della vasca: ");
            string input_min = Console.ReadLine();
            Min = Convert.ToInt32(input_min);
            Console.WriteLine("\nInserire il livello massimo di riempimento della vasca: ");
            string input_max = Console.ReadLine();
            Max = Convert.ToInt32(input_max);
        }

        public void RiempiVasca()
        {
            Console.WriteLine("Vasca in fase di riempimento.");
            acqua.Push(1);
        }

        public void SvuotaVasca()
        {
            Console.WriteLine("Vasca in fase di svuotamento.");
            acqua.Pop();
        }

        public void MostraLivello()
        {
            // gestisco qui la logica dell'eccezione all'interno della classe 
            if (acqua.Count() >= Max)
            {
                throw (new LivelloMaxRaggiunto("livello di riempimento massimo raggiunto."));
            }
            else if (acqua.Count() <= Min)
            {
                throw (new LivelloMinRaggiunto("livello di riempimento minimo raggiunto."));
            }
            else
            {
                Console.WriteLine("Livello dell'acqua: {0}", acqua.Count());
            }
        }
    }
}
