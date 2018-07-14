using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione13
{
    class Program
    {
        static int gcd(int x, int y)
        {
            if(y==0)
            {
                return x;
            }
            return gcd(y, x % y);
        }

        //Funzione che calcola il MCD in modo iterativo
        static void MCD(int x, int y)
        {
            int MCD = 0;
            if (y == 0)
            {
                MCD = x;
            }
            else
            {
                if (x % y == 0)
                {
                    MCD = y;
                }
                else
                {
                    while (y != 0)
                    {
                        int r = x % y;
                        x = y;
                        y = r;
                    }

                    MCD = x;
                }
            }

            Console.WriteLine("{0}", MCD);
        }

        static void Main(string[] args)
        {

            //Console.WriteLine("{0}", gcd(3, 6));

            MCD(5, 0);

            
            Console.ReadKey();
            

        }
    }
}
