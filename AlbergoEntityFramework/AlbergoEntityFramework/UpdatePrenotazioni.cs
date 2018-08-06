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
            Console.WriteLine("Inserisco una nuova prenotazione.");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            // inserisco una nuova prenotazione
            Prenotazioni prenotazione = new Prenotazioni();

            Console.WriteLine("Inserire la data di check-in:");
            System.DateTime checkIn = Convert.ToDateTime(Console.ReadLine());
            prenotazione.periodoDal = checkIn;
            Console.WriteLine("Inserire la data di check-out:");
            System.DateTime checkOut = Convert.ToDateTime(Console.ReadLine());
            prenotazione.periodoAl = checkOut;
            Console.WriteLine("Inserire il numero di camera:");
            short n_camera = Convert.ToInt16(Console.ReadLine());
            prenotazione.camera = n_camera;
            Console.WriteLine("Inserire l'id del cliente:");
            int id_cliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire il prezzo:");
            decimal prezzo_ = Convert.ToDecimal(Console.ReadLine());
            prenotazione.prezzoTotale = prezzo_;

            if (albergoDB.Prenotazioni.Any(o => o.idCliente == id_cliente))
            {
                prenotazione.idCliente = id_cliente;
                try
                {
                    albergoDB.Prenotazioni.Add(prenotazione);
                    albergoDB.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Messaggio di errore:{0}", ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("IdCliente non valido.");
            }
            Console.ReadKey();
        }

        // Metodo di lettura delle prenotazioni
        public static void LetturaPrenotazioni()
        {

            Console.WriteLine("Stampo tabella Prenotazioni");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            //var: sarà il compilatore a definire implicitamente il tipo della variabile
            var query1 = from p in albergoDB.Prenotazioni
                         select p;

            List<Prenotazioni> listaPrenotazioni = query1.ToList();

            Console.WriteLine("\t{0} \t {1} \t\t {2} {3} {4}", "PeriodoDal", "PeriodoAl", "Camera", "IdCliente", "PrezzoTotale");
            foreach (Prenotazioni pren in listaPrenotazioni)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", pren.periodoDal, pren.periodoAl, pren.camera, pren.idCliente, pren.prezzoTotale);
            }
            Console.ReadKey();
        }


    }
}
