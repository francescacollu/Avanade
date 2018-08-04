// Francesca Collu - settimana 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenMat
{
    // creazione della classe MyGenMat; matrici di generici
    public class MyGenMat<T>
    {
        // matrice generica
        private T[,] matrix;
        private int dim;
        
        // costruttore
        public MyGenMat(int dim)
        {
            this.dim = dim;
            matrix = new T[dim+1,dim+1];
        }

        // recupero un elemento
        public T getElement(int row, int col)
        {
            return matrix[row, col];
        }

        // setto un elemento
        public void setElement(int row, int col, T value)
        {
            matrix[row, col] = value;
        }

    }
}
