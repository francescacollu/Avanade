using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione16
{
    public class Persona
    {
        public static int numeroPersone;

        public Persona()
        {
            Persona.numeroPersone++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            Console.WriteLine("Numero persone: {0}", Persona.numeroPersone);

            Console.ReadKey();
        }
    }
}
