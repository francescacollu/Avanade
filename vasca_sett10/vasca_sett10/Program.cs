// Francesca Collu - settimana 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace vasca_sett10
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
                int livello = rand.Next(vasca.Min+ 1, vasca.Max + 1);
                for (int i = 1; i <= livello; i++)
                {
                    vasca.Acqua.Push(i);
                }

                Console.WriteLine("La vasca è inizialmente riempita al livello di " + livello + " litri.");

                Console.WriteLine("Per quanto tempo si vuole riempire/svuotare la vasca?");
                string risp1 = Console.ReadLine();
                int sec1 = Convert.ToInt32(risp1);
                

                Random num = new Random();
                    try
                    {
                        time.Start();
                        while (time.Elapsed < TimeSpan.FromSeconds(sec1))
                        {
                            int scelta = num.Next(0, 2);

                            if (scelta == 0)
                            {
                                vasca.SvuotaVasca();
                                vasca.MostraLivello();
                            }
                            else if (scelta == 1)
                            {
                                vasca.RiempiVasca();
                                vasca.MostraLivello();
                            }
                        }
                        time.Stop();
                        vasca.MostraLivello();
                    }
                    catch (LivelloMaxRaggiunto e)
                    {
                        Console.WriteLine("Eccezione sollevata: {0}", e.Message);
                        Console.WriteLine("Si vuole svuotare la vasca? [s] per continuare, [n] per uscire.");
                        string rispSv = Console.ReadLine();
                        char rispSvCh = Convert.ToChar(rispSv);


                        if (rispSvCh == 's')
                        {
                            Console.WriteLine("Di quanti litri?");
                            string rispSv3 = Console.ReadLine();
                            int litriSv = Convert.ToInt32(rispSv3);
                            
                            for(int j=1; j<=litriSv; j++)
                            {
                                try
                                {
                                    vasca.SvuotaVasca();
                                    vasca.MostraLivello();
                                }
                                catch (LivelloMinRaggiunto excMin)
                                {
                                    Console.WriteLine("Eccezione sollevata: {0}", excMin.Message);
                                }
                            }   
                        }
                        else { break; }
                    }
                    catch (LivelloMinRaggiunto e2)
                    {
                        Console.WriteLine("Eccezione sollevata: {0}", e2.Message);
                        Console.WriteLine("Si vuole riempire la vasca? [s] per continuare, [n] per uscire.");
                        string rispRiemp = Console.ReadLine();
                        char rispRiempCh = Convert.ToChar(rispRiemp);

                        if (rispRiempCh == 's')
                        {
                            Console.WriteLine("Di quanti litri?");
                            string rispSv3 = Console.ReadLine();
                            int litriR = Convert.ToInt32(rispSv3);

                            for (int j = 1; j <= litriR; j++)
                            {
                                try
                                {
                                    vasca.RiempiVasca();
                                    vasca.MostraLivello();
                                }
                                catch (LivelloMaxRaggiunto excMax)
                                {
                                    Console.WriteLine("Eccezione sollevata: {0}", excMax.Message);
                                }
                            }
                            
                        }
                        else { break; }
                    }

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
