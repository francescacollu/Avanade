// Francesca Collu - settimana 8
// Uso della classe astratta che rappresenta i comportamenti comuni degli oggetti dadi e moneta

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadi
{
    public abstract class OggettoAleatorio
    {
        protected double Result;

        public virtual void Lancio()
        {
            Console.WriteLine("Lancio avvenuto!");
        }
    }

    public class Dado : OggettoAleatorio
    {
        private int nFacce;
        

        private int NFacce
        {
            get { return nFacce; }
            set { nFacce = value; }
        }

        public int NumeroFacce()
        {
            Dado dado = new Dado();
            string userInput;
            Console.WriteLine("Quante sono le facce di questo dado?");
            userInput = Console.ReadLine();
            dado.nFacce = Convert.ToInt32(userInput);
            return dado.nFacce;
        }



    }

    public class Moneta : OggettoAleatorio
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dado dado = new Dado();
            char scelta;
            string userInput;
            Console.WriteLine("Scegliere se si vuole lanciare un dado [d] o una moneta [m]: ");
            userInput = Console.ReadLine();
            scelta = Convert.ToChar(userInput);

            switch (scelta)
            {
                case 'd':
                    dado.NumeroFacce();
                    dado.Lancio();
                    //dado
                    //dado.NumeroFacce(); - da 3 in su.
                    //dado.Lancia();
                    //dado.Ferma();
                    //dado.LeggiNumero();
                    break;

                case 'm':
                    //moneta
                    //moneta.Lancia();
                    //moneta.Ferma();
                    //moneta.LeggiNumero();
                    break;
            }

            Console.ReadKey();
        }
    }
}
