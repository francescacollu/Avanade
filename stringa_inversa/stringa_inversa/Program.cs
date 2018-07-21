using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringa_inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivere una stringa: ");
            string s = Console.ReadLine();

            for(int i=s.Length-1; i>=0; i--)
            {
                Console.Write(s[i]);
            }

            Console.ReadKey();
        }
    }
}
