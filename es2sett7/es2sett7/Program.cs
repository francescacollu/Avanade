// Francesca Collu - Esercitazione settimana 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es2sett7
{
    // superclasse - Essendo la superclasse caratterizzata unicamente da metodi, si sarebbe potuta realizzare una interfaccia IBandaMusicale.
    public class BandaMusicale
    {
        // metodi virtuali
        public virtual void MusicOn()
        {
            Console.WriteLine("Inizia a suonare");
        }

        public virtual void MusicOff()
        {
            Console.WriteLine("Smette di suonare");
        }
    }

    // classe derivata
    class Voce : BandaMusicale
    {
        public override void MusicOn()
        {
            Console.WriteLine("Voce ON");
        }

        public override void MusicOff()
        {
            Console.WriteLine("Voce OFF");
        }
    }

    // classe derivata
    class Sassofono : BandaMusicale
    {
        public override void MusicOn()
        {
            Console.WriteLine("Sax ON");
        }

        public override void MusicOff()
        {
            Console.WriteLine("Sax OFF");
        }
    }

    // classe derivata
    class Batteria : BandaMusicale
    {
        public override void MusicOn()
        {
            Console.WriteLine("Batteria ON");
        }

        public override void MusicOff()
        {
            Console.WriteLine("Batteria OFF");
        }
    }

    // classe derivata
    class Contrabbasso : BandaMusicale
    {
        public override void MusicOn()
        {
            Console.WriteLine("Contrabbasso ON");
        }

        public override void MusicOff()
        {
            Console.WriteLine("Contrabbasso OFF");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Voce voce = new Voce();
            Sassofono sax = new Sassofono();
            Batteria batteria = new Batteria();
            Contrabbasso contrabbasso = new Contrabbasso();

            bool again = true;
            while (again)
            {
                Console.WriteLine("Sei il direttore della banda. Inizia a dirigere in qualunque momento. \nScegli gli strumenti che vuoi far suonare:" +
                 "\n[a] voce \n[b] sassofono \n[c] batteria \n[d] contrabbasso \n[e] chiudere il concerto");
                string userInput = Console.ReadLine();
                char c = Convert.ToChar(userInput);

                switch (c)
                {
                    case 'a':
                        voce.MusicOn();
                        break;

                    case 'b':
                        sax.MusicOn();
                        break;

                    case 'c':
                        batteria.MusicOn();
                        break;

                    case 'd':
                        contrabbasso.MusicOn();
                        break;

                    case 'e':
                        Console.WriteLine("Posare la bacchetta.");
                        break;
                }
                Console.WriteLine("Vuoi continuare? [s] per sì, [n] per no.");
                userInput = Console.ReadLine();
                char risposta = Convert.ToChar(userInput);
                if (risposta == 's') { again = true; }
                else
                {
                    again = false;
                    Console.WriteLine("Puoi posare la bacchetta.");
                }
            }

            Console.ReadKey();
        }


    }
}
