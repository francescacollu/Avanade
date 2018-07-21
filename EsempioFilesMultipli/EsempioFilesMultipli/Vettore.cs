using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioFilesMultipli
{
    class Vettore
    {
        int l;
        int[] v;
        public Vettore(int[] vett, int n) //metodo costruttore invocato dal Program quando istanzio l'oggetto
        {
            l = n;
            v = vett;
        }
        public int[] ordina()
        {
            int scambio;
            for (int i = 0; i < l - 1; i++)
            {
                for (int j = i; j < l; j++)
                {
                    if (v[i] > v[j])
                    {
                        scambio = v[i];
                        v[i] = v[j];
                        v[j] = scambio;
                    }
                }
            }
            return v;
        }
        public int calcolaMax()
        {
            int max;
            max = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                /*if (i == 0) 
                {
                    max = v[i];
                }*/
                if (v[i] > max)
                {
                    max = v[i];
                }
            }
            return max;
        }
        public int calcolaMin()
        {
            int min;
            min = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                /*if (i == 0) 
                {
                    min = v[i];
                }*/
                if (v[i] < min)
                {
                    min = v[i];
                }
            }
            return min;
        }

    }
}
