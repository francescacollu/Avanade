using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbergoEntityFramework
{
    class UpdatePrenotazioni
    {
        public static void InserimentoPrenotazione()
        {
            Console.WriteLine("Inserisco cliente Marco Bianchetti");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            // inserisco una nuova prenotazione
            Prenotazioni prenotazione = new Prenotazioni();
            prenotazione.periodoDal = "Via Milano 2";
            prenotazione.periodoAl = "Marco Bianchetti";
            prenotazione.camera = "444444444";
            prenotazione.idCliente = "";
            prenotazione.prezzoTotale = "";

            try
            {
                albergoDB.Prenotazioni.Add(prenotazione);
                albergoDB.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Messaggio di errore:{0}", ex.ToString());
            }
            Console.ReadKey();
        }


    }
}
