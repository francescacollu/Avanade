using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio03
{
    // creazione di una classe che fa uso di generici
    public class MyGenericArray<T>
    {
        // vettore generico
        private T[] array;

        // costruttore
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        // recupero un elemento
        public T getItem(int index)
        {
            return array[index];
        }

        // setto un elemento
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
