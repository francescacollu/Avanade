// Francesca Collu - settimana 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace riempimento_vasca
{
    class TestVasca
    {
        static void Main(string[] args)
        {
            Vasca vasca = new Vasca();

            Stopwatch time = new Stopwatch();

            bool again = true;
            while (again)
            {
                vasca.LeggiLivelli();

                Random rand = new Random();
                int livello = rand.Next(vasca.Min, vasca.Max + 1);
                for (int i = 1; i <= livello; i++)
                {
                    vasca.Acqua.Push(i);
                }

                Console.WriteLine("La vasca è inizialmente riempita al livello di " + livello + " litri.");

                Console.WriteLine("Per quanto tempo si vuole riempire/svuotare la vasca?");
                string risp1 = Console.ReadLine();
                int sec1 = Convert.ToInt32(risp1);
                time.Start();

                while (time.Elapsed < TimeSpan.FromSeconds(sec1))
                {
                    try
                    {
                        Random num = new Random();
                        int scelta = num.Next(0, 2);

                        if(scelta == 0)
                        {
                            vasca.SvuotaVasca();
                            vasca.MostraLivello();
                        }
                        else if (scelta == 1)
                        {
                            vasca.SvuotaVasca();
                            vasca.MostraLivello();
                        }
                    }
                    catch (LivelloMaxRaggiunto e)
                    {
                        Console.WriteLine("Eccezione sollevata: {0}", e.Message);
                        break;
                    }
                    catch (LivelloMinRaggiunto e2)
                    {
                        Console.WriteLine("Eccezione sollevata: {0}", e2.Message);
                        break;
                    }
                }
                time.Stop();

                Console.WriteLine("Si vuole continuare a riempire o svuotare una nuova vasca? [s] per continuare, [n] per uscire.");
                string risp2 = Console.ReadLine();
                char risp3 = Convert.ToChar(risp2);

                if (risp3 == 's')
                {
                    again = true;
                }

                else
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
