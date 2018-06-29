// Francesca Collu - esercitazione settimana 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StanzaAlbergo
{

    public class StanzaAlbergo
    {
        // attributi privati
        private int numero;
        private string cliente;
        DateTime checkIn = new DateTime();
        DateTime checkOut = new DateTime();

        // attributi accessori
        private float prezzo; // prezzo della stanza a notte
        private string tipo, piano;
        private int lettiAggiuntivi;

        // costruttore
        public StanzaAlbergo(int numero, DateTime checkIn, DateTime checkOut, string cliente)
        {
            this.numero = numero;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.cliente = cliente;
        }

        // costruttore di default
        public StanzaAlbergo()
        {
            numero = 0;
        }

        // proprietà
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        // metodo accessorio di scrittura della stanza
        public override string ToString()
        {
            return "Stanza "+ Numero +" prenotata dal "+ CheckIn +" al "+ CheckOut +" da "+ Cliente +".";
        }

        // metodo che permette di inserire i dati del cliente (nome, date di arrivo e partenza)
        public void Dati()
        {
            Console.WriteLine("Inserire nome e cognome del cliente: ");
            Cliente = Console.ReadLine();
            Console.WriteLine("Inserire la data di check-in (formato YYYY-MM-DD): ");
            string userInput = Console.ReadLine();
            CheckIn = Convert.ToDateTime(userInput);
            Console.WriteLine("Inserire la data di check-out (formato YYYY-MM-DD): ");
            userInput = Console.ReadLine();
            CheckOut = Convert.ToDateTime(userInput);
        }

    }

    public class Prenotazione
    {
        // attributi privati
        private StanzaAlbergo stanza = new StanzaAlbergo();
        private DateTime dataIn = new DateTime();
        private DateTime dataOut = new DateTime();

        // costruttore
        public Prenotazione(StanzaAlbergo stanza, DateTime dataIn, DateTime dataOut)
        {
            this.stanza = stanza;
            this.dataIn = dataIn;
            this.dataOut = dataOut;
        }

        // costruttore di default
        public Prenotazione()
        {
            DateTime d01 = new DateTime(0000, 00, 00);
            DateTime d02 = d01;
            stanza = new StanzaAlbergo(0, d01, d02, "No name");
        }

        // proprietà
        public StanzaAlbergo Stanza
        {
            get { return stanza; }
            set { stanza = value; }
        }
        public DateTime DataIn
        {
            get { return dataIn; }
            set { dataIn = value; }
        }
        public DateTime DataOut
        {
            get { return dataOut; }
            set { dataOut = value; }
        }

        // metodo che gestisce la prenotazione di una certa stanza
        public void Gestione(StanzaAlbergo stanza, StanzaAlbergo stanzaAlbergo)
        {
            if (stanza.CheckIn < stanzaAlbergo.CheckIn)
            {
                if (stanza.CheckOut < stanzaAlbergo.CheckIn)
                {
                    Console.WriteLine("La stanza " + stanzaAlbergo.Numero + " è libera nel periodo inserito.");
                }
                else if(stanza.CheckOut >= stanzaAlbergo.CheckIn || stanza.CheckOut >= stanzaAlbergo.CheckOut)
                {
                    Console.WriteLine("La stanza " + stanzaAlbergo.Numero + " è già occupata.");
                }
            }
            else if (stanza.CheckIn >= stanzaAlbergo.CheckIn && stanza.CheckIn < stanzaAlbergo.CheckOut)
            {
                Console.WriteLine("La stanza " + stanzaAlbergo.Numero + " è già occupata.");
            }
            else if(stanza.CheckIn >= stanzaAlbergo.CheckOut && stanza.CheckOut > stanzaAlbergo.CheckOut)
            {
                Console.WriteLine("La stanza " + stanzaAlbergo.Numero + " è libera nel periodo inserito.");
            }
        }

        // metodo che permette di inserire i dati ai fini della prenotazione
        public void DatiPrenotazione()
        {
            Console.WriteLine("Inserire nome e cognome del cliente: ");
            stanza.Cliente = Console.ReadLine();
            Console.WriteLine("Inserire la data di check-in (formato YYYY-MM-DD): ");
            string userInput = Console.ReadLine();
            stanza.CheckIn = Convert.ToDateTime(userInput);
            Console.WriteLine("Inserire la data di check-out (formato YYYY-MM-DD): ");
            userInput = Console.ReadLine();
            stanza.CheckOut = Convert.ToDateTime(userInput);
            Console.WriteLine("Inserire il numero di stanza libera: ");
            userInput = Console.ReadLine();
            stanza.Numero = Convert.ToInt32(userInput);
            Console.WriteLine("La prenotazione della stanza " + stanza.Numero + " è andata a buon fine.");
            stanza.ToString();

        }

    }



    class Test
    {
        static void Main(string[] args)
        {
            // istanziazione delle date in cui le stanze d'albergo saranno occupate
            DateTime data1in = new DateTime(2018, 08, 10); //data di check-in
            DateTime data1out = new DateTime(2018, 08, 17); // data di check-out
            DateTime data2in = new DateTime(2018, 07, 15);
            DateTime data2out = new DateTime(2018, 07, 23);

            // istanziazione delle quattro camere presenti nell'albergo
            StanzaAlbergo stanza1 = new StanzaAlbergo(1, data1in, data1out, "Michelangelo Merisi");
            StanzaAlbergo stanza2 = new StanzaAlbergo(2, data2in, data2out, "Raffaello Sanzio");
            StanzaAlbergo stanza3 = new StanzaAlbergo(3, data2in, data2out, "Leonardo Da Vinci");
            StanzaAlbergo stanza4 = new StanzaAlbergo(4, data2in, data2out, "Donatello Bardi");

            List<StanzaAlbergo> stanze = new List<StanzaAlbergo>();
            stanze.Add(stanza1);
            stanze.Add(stanza2);
            stanze.Add(stanza3);
            stanze.Add(stanza4);

            // istanziazione della prenotazione
            StanzaAlbergo stanza = new StanzaAlbergo();
            stanza.Dati();
            Prenotazione prenotazione_stanza = new Prenotazione(stanza, stanza.CheckIn, stanza.CheckOut);

            foreach (StanzaAlbergo stanzaAlbergo in stanze)
            {
                prenotazione_stanza.Gestione(stanza, stanzaAlbergo);
            }

            prenotazione_stanza.DatiPrenotazione();

            Console.ReadKey();
        }
    }
}
