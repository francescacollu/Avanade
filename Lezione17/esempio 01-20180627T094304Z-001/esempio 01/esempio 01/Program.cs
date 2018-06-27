using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esempio_01
{
    // classe motore
    class Motore
    {
        private int cilindrata;
        public Motore(int cc)
        {
            cilindrata = cc;
        }
        public void Accendi()
        {
            Console.WriteLine("Vrooom!!");
        }
    }

    // classe serbatoio
    class Serbatoio
    {
        float capacita;
        float carburante;
        public Serbatoio(float cap)
        {
            capacita = cap;
            carburante = 0.0f;
        }
        public float Capacità
        {
            get
            {
                return this.capacita;
            }
        }
        public float Carburante
        {
            get
            {
                return carburante;
            }
            set
            {
                if (value > 0)
                {
                    if (carburante + value > capacita)
                        carburante = capacita;
                    else carburante += value;
                }
            }
        }
    }

    // classe auto
    class Auto
    {
        private int numeroRuote;
        private string modello;
        private Motore motore;
        private Serbatoio serbatoio;
        public Auto(string mod, int cilindrata)
        {
            numeroRuote = 4;
            modello = mod;
            motore = new Motore(cilindrata);
            serbatoio = new Serbatoio(50.0f);
        }
        public bool Accensione()
        {
            if (serbatoio.Carburante > 0)
            {
                this.motore.Accendi();
                return true;
            }
            else return false;
        }
        public void RiempiSerbatoio()
        {
            serbatoio.Carburante = serbatoio.Capacità;
        }
    }



    class Test_Auto
    {
        static void Main(string[] args)
        {
        }
    }
}
