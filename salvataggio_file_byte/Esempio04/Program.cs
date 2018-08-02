using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // libreria per input e output

namespace Esempio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // creazione/apertura di un file binario in lettura/scrittura
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
               FileAccess.ReadWrite);

            // genero 20 numeri e li salvo convertiti in byte dentro il file binario
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            // posiziono a 0 la testina dell'indicizzatore file binario
            F.Position = 0;
            // lettura del file binario 
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            // chiudo il file
            F.Close();
            Console.ReadKey();
        }
    }
}
