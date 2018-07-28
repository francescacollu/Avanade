using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    // creazione di un'eccezzione personalizzata
    public class VascaPienaException : Exception
    {
        public VascaPienaException(string message) : base(message)
        {
            // Console.WriteLine("messaggio che desidero inoltrare");
            // log ecc...
        }
    }

    // classe che solleva l'eccezione personalizzata
    public class Vasca
    {
        Stack<int> vasca = new Stack<int>();
        int litro;

        public int Litro
        {
            get { return litro; }
        }

        public void Riempimento()
        {
            vasca.Push(litro++);
        }

        public void showLevel()
        {
            // gestisco qui la logica dell'eccezione all'interno della classe 
            if (litro == 5)
            {
                throw (new VascaPienaException("Massimo della vasca raggiunto"));
            }
            else
            {
                Console.WriteLine("VascaLivello: {0}", vasca);
            }
        }
    }
}

