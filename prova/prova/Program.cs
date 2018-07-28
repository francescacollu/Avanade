using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> liquido = new Stack<int>();
            liquido.Push(0);

            liquido.Push(liquido.Peek() + 1);
            Console.WriteLine("Il livello di riempimento è " + liquido.Peek());
            liquido.Push(liquido.Peek() + 2);
            Console.WriteLine("Il livello di riempimento è " + liquido.Peek());

            Console.ReadLine();
        }
    }

    /*class Car
    {
        private string color;

        //costruttore
        public Car(string color)
        {
            this.color = color;
        }

        //metodo Describe
        public string Describe()
        {
            return "This car is " + Color;
        }

        //metodo Color
        public string Color
        {
            get { return color.ToUpper(); }
            set
            {
                if (value == "Red") { color = value; }
                else { Console.WriteLine("This car can only be red!"); }
            }
        }
    }*/
}
