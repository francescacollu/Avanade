using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Esempio_02
{
    using System;
    using System.Diagnostics;

    public class ExampleClass
    {
        Stopwatch sw;

        public ExampleClass()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Oggetto istanziato");
        }

        public void ShowDuration()
        {
            Console.WriteLine("L'istanza dell'ogetto {0} è presente da: {1} secondi",
                              this, sw.Elapsed);
        }

        // distruttore [viene invocato automaticamente dal Garbage Collector ma lo posso programmare ad hoc]
        ~ExampleClass()
        {
            Console.WriteLine("Finalizzazione oggetto");
            sw.Stop();
            Console.WriteLine("L'istanza dell'ogetto {0} è stato eliminto dopo: {1} secondi",
                              this, sw.Elapsed);
        }
    }

    public class Demo
    {
        public static void Main()
        {
            {
                ExampleClass ex = new ExampleClass();
                ex.ShowDuration();
                System.Threading.Thread.Sleep(5000);
                ex.ShowDuration();
                System.Threading.Thread.Sleep(2000);
                // faccio puntare l'oggetto a null
                ex = null;
                // invocando il metodo Collect del Garbage Collector di fato elimino l'oggetto ex e libero la memoria
                GC.Collect();
            }
            Console.ReadKey();  
        }
    }
}
