// Francesca Collu - esercitazione settimana 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StanzaAlbergo
{
    public class Prenotazione
    {
        // attributi
        private DateTime checkIn; 
        private DateTime checkOut;
        private string cliente;

        // costruttore
        public Prenotazione(DateTime checkIn, DateTime checkOut, string cliente)
        {
            this.checkIn = new DateTime();
            this.checkOut = new DateTime();
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.cliente = cliente;
        }

        // proprietà
        public DateTime CheckIn
        {
            get { return checkIn; }
        }
        public DateTime CheckOut
        {
            get { return checkOut; }
        }
        public string Cliente
        {
            get { return cliente; }
        }

        // metodo che studia la sovrapposizione tra gli intervalli di prenotazione (true per overlap, false per overlap)
        static public bool OverLap(Prenotazione i1, Prenotazione i2)
        {
            //if ((i1.CheckIn < i2.CheckIn && i1.CheckOut < i2.CheckIn) || (i1.CheckIn > i2.CheckOut && i1.CheckOut > i2.CheckOut) ||  !(i1.CheckIn<i2.CheckIn && i1.CheckOut > i2.CheckOut) || !(i1.CheckIn > i2.CheckOut && i1.CheckOut < i2.CheckOut))
            if(i1.CheckOut <= i2.CheckIn || i1.CheckIn >= i2.CheckOut)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class StanzaAlbergo
    {
        // attributi privati
        private int numero;
        List<Prenotazione> prenotazioni; 

        // attributi accessori (che non verranno usati in questo programma)
        private float prezzo;
        private string tipo, piano;
        private int lettiAggiuntivi;

        // costruttore
        public StanzaAlbergo(int numero)
        {
            this.numero = numero;
            prenotazioni = new List<Prenotazione>();
        }

        // costruttore di default
        public StanzaAlbergo()
        {
            numero = -1;
        }

        // proprietà
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public List<Prenotazione> Prenotazioni
        {
            get { return prenotazioni; }
        }


        // metodo che aggiunge prenotazione
        public void Prenota(Prenotazione p)
        {
            prenotazioni.Add(p);
        }

    }



    class Test
    { 
        static void Main(string[] args)
        {

            // istanziazione delle due camere presenti nell'albergo
            StanzaAlbergo stanza1 = new StanzaAlbergo(1);
            StanzaAlbergo stanza2 = new StanzaAlbergo(2);
            //StanzaAlbergo stanza3 = new StanzaAlbergo(3);
            //StanzaAlbergo stanza4 = new StanzaAlbergo(4);

            List<StanzaAlbergo> stanze = new List<StanzaAlbergo>();
            stanze.Add(stanza1);
            stanze.Add(stanza2);
            //stanze.Add(stanza3);
            //stanze.Add(stanza4);

            // istanziazione della prenotazione
            while(true)
            {
                string Cliente;
                DateTime CheckIn, CheckOut;

                Console.WriteLine("Inserire nome e cognome del cliente: ");
                Cliente = Console.ReadLine();
                Console.WriteLine("Inserire la data di check-in (formato YYYY-MM-DD): ");
                string userInput = Console.ReadLine();
                CheckIn = Convert.ToDateTime(userInput);
                Console.WriteLine("Inserire la data di check-out (formato YYYY-MM-DD): ");
                userInput = Console.ReadLine();
                CheckOut = Convert.ToDateTime(userInput);
                Prenotazione richiesta = new Prenotazione(CheckIn, CheckOut, Cliente);

                bool albergoPieno = true;

                foreach (StanzaAlbergo stanza in stanze)
                {
                    bool libera = false;
                    if (stanza.Prenotazioni.Count == 0)
                    {
                        libera = true;
                        albergoPieno = false;
                        stanza.Prenota(richiesta);
                        Console.WriteLine("La stanza #" + stanza.Numero + " è stata prenotata dal " + richiesta.CheckIn + " al " + richiesta.CheckOut + " a nome di " + richiesta.Cliente + ".");
                        break;
                    }

                    foreach (Prenotazione prenotazione in stanza.Prenotazioni)
                    {
                        if (!Prenotazione.OverLap(prenotazione, richiesta))
                        {
                            libera = true;
                            albergoPieno = false;
                            stanza.Prenota(richiesta);
                            Console.WriteLine("La stanza #" + stanza.Numero+ " è stata prenotata dal " + richiesta.CheckIn + " al " + richiesta.CheckOut + " a nome di " +richiesta.Cliente  + ".");
                            break;
                        }
                    }
                    if(libera) 
                        break;

                }
                if (albergoPieno) Console.WriteLine("L'albergo è pieno!");

                foreach (StanzaAlbergo stanza in stanze)
                {
                    Console.WriteLine("La stanza #" + stanza.Numero + " ha " + stanza.Prenotazioni.Count + " prenotazioni.");
                }

            }
        }
    }
}
