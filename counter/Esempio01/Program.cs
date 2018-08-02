using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // genero una soglia massima random 
            Counter c = new Counter(new Random().Next(10));
            Console.WriteLine("La soglia massima è: "+c.Threshold);

            // lego l'evento alla funzione handler 
            c.ThresholdReached += c_ThresholdReached;

            // incremento il totale fino al raggiungimento della soglia
            Console.WriteLine("premi 'a' per incrementare il totale");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("aggiunta una unità");
                c.Add(1);
            }
        }

        // programmo la funzione handler dell'evento
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("La soglia è stata raggiunta");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
