using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio01
{
    class LINQQueryExpressions
    {
        static void Main()
        {

            // Struttura data di partenza
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Definizione della quey
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Scansione della query
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
