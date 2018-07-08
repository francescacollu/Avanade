// Francesca Collu - esercitazione settimana 7

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
        List<Prenotazione> prenotazioni; 
        private double prezzo;
        private char tipologia;

        // costruttore
        public StanzaAlbergo(int numero, double prezzo, char tipologia)
        {
            this.numero = numero;
            this.prezzo = prezzo;
            this.tipologia = tipologia;
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
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }
        public char Tipologia
        {
            get { return tipologia; }
            set { tipologia = value; }
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

    public class Prenotazione
    {
        // attributi
        private DateTime checkIn;
        private DateTime checkOut;
        private string cliente;
        private char tipologiaRichiesta;
        private int lettiAggiuntivi;

        // costruttore
        public Prenotazione(DateTime checkIn, DateTime checkOut, string cliente, char tipologiaRichiesta, int lettiAggiuntivi)
        {
            this.checkIn = new DateTime();
            this.checkOut = new DateTime();
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.cliente = cliente;
            this.tipologiaRichiesta = tipologiaRichiesta;
            this.lettiAggiuntivi = lettiAggiuntivi;
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
        public char TipologiaRichiesta
        {
            get { return tipologiaRichiesta; }

        }
        public int LettiAggiuntivi
        {
            get { return lettiAggiuntivi; }
            set { lettiAggiuntivi = value; }
        }

        // metodo che studia la sovrapposizione tra gli intervalli di prenotazione (true per overlap, false per overlap)
        static public bool OverLap(Prenotazione i1, Prenotazione i2)
        {
            if (i1.CheckOut <= i2.CheckIn || i2.CheckOut <= i1.CheckIn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool RichiestaStanza(Prenotazione i, StanzaAlbergo s)
        {
            if (i.TipologiaRichiesta == s.Tipologia) return true;
            else return false;
        }

        //metodo per l'aggiunta di letti
        public void AggiungiLetti(Prenotazione p)
        {
            string userInput;
            char a;
            Console.WriteLine("Si vuole inserire letti aggiuntivi? ['s' per sì, 'n' per no]");
            userInput = Console.ReadLine();
            a = Convert.ToChar(userInput);
            if (a == 's')
            {
                string nInput;
                int n;
                Console.WriteLine("Quanti letti si vuole aggiungere?");
                nInput = Console.ReadLine();
                n = Convert.ToInt32(nInput);
                p.LettiAggiuntivi = p.LettiAggiuntivi + n;
            }
            else if (a == 'n') Console.WriteLine("Non sono stati aggiunti letti.");
        }
    }

    class TestPrenotazioni
    { 
        static void Main(string[] args)
        {
            double prezzoLetto = 20;

            // istanziazione delle due camere presenti nell'albergo
            StanzaAlbergo stanza1 = new StanzaAlbergo(1, 50, 's');
            StanzaAlbergo stanza2 = new StanzaAlbergo(2, 80, 'm');
            StanzaAlbergo stanza3 = new StanzaAlbergo(3, 50, 's');
            StanzaAlbergo stanza4 = new StanzaAlbergo(4, 80, 'm');

            List<StanzaAlbergo> stanze = new List<StanzaAlbergo>();
            stanze.Add(stanza1);
            stanze.Add(stanza2);
            stanze.Add(stanza3);
            stanze.Add(stanza4);

            // istanziazione della prenotazione
            while(true)
            {
                string Cliente;
                DateTime CheckIn, CheckOut;
                char TipologiaRichiesta;
                int LettiAggiuntivi = 0;

                Console.WriteLine("Inserire nome e cognome del cliente: ");
                Cliente = Console.ReadLine();
                Console.WriteLine("Inserire la data di check-in (formato YYYY-MM-DD): ");
                string userInput = Console.ReadLine();
                CheckIn = Convert.ToDateTime(userInput);
                Console.WriteLine("Inserire la data di check-out (formato YYYY-MM-DD): ");
                userInput = Console.ReadLine();
                CheckOut = Convert.ToDateTime(userInput);
                Console.WriteLine("Inserire il tipo di stanza che si vuole prenotare ['s' per singola o 'm' per matrimoniale]");
                userInput = Console.ReadLine();
                TipologiaRichiesta = Convert.ToChar(userInput);
                if (TipologiaRichiesta != 's' && TipologiaRichiesta != 'm')
                {
                    Console.WriteLine("Carattere non valido.");
                    continue;
                }
                Prenotazione richiesta = new Prenotazione(CheckIn, CheckOut, Cliente, TipologiaRichiesta, LettiAggiuntivi);

                bool albergoPieno = true;

                foreach (StanzaAlbergo stanza in stanze)
                {
                    if (!Prenotazione.RichiestaStanza(richiesta, stanza)) { continue; }

                    bool prenotata = false;
                    bool libera = true;
                    if (stanza.Prenotazioni.Count == 0)
                    {
                        prenotata = true;
                        albergoPieno = false;
                        stanza.Prenota(richiesta);
                        Console.WriteLine("La stanza #" + stanza.Numero + " è stata prenotata dal " + richiesta.CheckIn + " al " + richiesta.CheckOut + " a nome di " + richiesta.Cliente + ".\n");
                        System.TimeSpan diff = richiesta.CheckOut - richiesta.CheckIn;
                        int n_days = Convert.ToInt32(diff.Days);
                        richiesta.AggiungiLetti(richiesta);
                        double spesa = stanza.Prezzo + richiesta.LettiAggiuntivi * prezzoLetto;
                        spesa = n_days * spesa;
                        Console.WriteLine("La stanza #" + stanza.Numero + " è stata prenotata dal " + richiesta.CheckIn + " al " + richiesta.CheckOut + " a nome di " + richiesta.Cliente + ", con " + richiesta.LettiAggiuntivi + " letti aggiuntivi. \nLa spesa totale è di "+ spesa + " euro. \n");
                        break;
                    }

                    foreach (Prenotazione prenotazione in stanza.Prenotazioni)
                    {
                        libera = libera && !Prenotazione.OverLap(prenotazione, richiesta);
                        if (!libera) break;
                    }

                    if (libera)
                    {
                        prenotata = true;
                        albergoPieno = false;
                        stanza.Prenota(richiesta);
                        Console.WriteLine("La stanza #" + stanza.Numero + " è stata prenotata dal " + richiesta.CheckIn + " al " + richiesta.CheckOut + " a nome di " +richiesta.Cliente  + ".\n");
                        System.TimeSpan diff = richiesta.CheckOut - richiesta.CheckIn;
                        int n_days = Convert.ToInt32(diff.Days);
                        richiesta.AggiungiLetti(richiesta);
                        double spesa = stanza.Prezzo + richiesta.LettiAggiuntivi * prezzoLetto;
                        spesa = n_days * spesa;
                        Console.WriteLine("La stanza #" + stanza.Numero + " è stata prenotata dal " + richiesta.CheckIn + " al " + richiesta.CheckOut + " a nome di " + richiesta.Cliente + ", con " + richiesta.LettiAggiuntivi + " letti aggiuntivi. \nLa spesa totale è di " + spesa + " euro.\n");
                        break;
                    }

                    if(prenotata) 
                        break;

                }
                if (albergoPieno) Console.WriteLine("Non ci sono stanze disponibili nel periodo richiesto.");

                foreach (StanzaAlbergo stanza in stanze)
                {
                    Console.WriteLine("La stanza #" + stanza.Numero + " ha " + stanza.Prenotazioni.Count + " prenotazioni.");

                    foreach (Prenotazione prenotazione in stanza.Prenotazioni)
                    {
                        Console.WriteLine("La stanza " + stanza.Numero + " è stata prenotata da " + prenotazione.Cliente + " dal " + prenotazione.CheckIn + " al " + prenotazione.CheckOut + ".");
                    }
                }

            }
        }
    }
}