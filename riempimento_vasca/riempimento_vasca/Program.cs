using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    class TestVasca
    {
        static void Main(string[] args)
        {
            // creo un oggetto vasca
            Vasca vasca = new Vasca();

            Stack<int> livello = new Stack<int>();

            vasca.Riempimento();

            Console.WriteLine("Il livello è :" +vasca.Litro);
            try
            {
                vasca.showLevel();
            }
            catch (VascaPienaException e)
            {
                Console.WriteLine("Eccezione sollevata: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}