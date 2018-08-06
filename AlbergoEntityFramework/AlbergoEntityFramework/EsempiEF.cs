using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlbergoEntityFramework
{
    class EsempiEF
    {
        public static void testInserimento()
        {
            Console.WriteLine("Inserisco cliente Marco Bianchetti");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            // inserisco un cliente
            Clienti cliente = new Clienti();
            cliente.indirizzo = "Via Milano 2";
            cliente.nominativo = "Marco Bianchetti";
            cliente.telefono = "444444444";

            try
            {
                albergoDB.Clienti.Add(cliente);
                albergoDB.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Messaggio di errore:{0}", ex.ToString());
            }
            Console.ReadKey();
        }//fine test

        //Test lettura con oggetti appartenenti al modello delle entità
        public static void testLettura1()
        {

            Console.WriteLine("Stampo tabella Clienti");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            //var: sarà il compilatore a definire implicitamente il tipo della variabile (cli è un Clienti)
            var query1 = from cli in albergoDB.Clienti
                         select cli;

            List<Clienti> lista = query1.ToList();

            foreach (Clienti c in lista)
            {
                Console.WriteLine("{0} \t {1} \t {2}", c.nominativo, c.indirizzo, c.telefono);
            }
            Console.ReadKey();
        }//fine test

        //Test lettura con oggetti anonimi
        public static void testLettura2()
        {

            Console.WriteLine("Stampo tabella Clienti");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            //var: sarà il compilatore a definire implicitamente il tipo della variabile (il risultato è un tipo anonimo)
            var query2 = from cli in albergoDB.Clienti
                         select new { cli.nominativo, cli.indirizzo, cli.telefono };


            foreach (var e in query2)// solo in lettura!
            {
                Console.WriteLine("{0} \t {1} \t {2}", e.nominativo, e.indirizzo, e.telefono);
            }

            Console.ReadKey();
        }//fine test

        public static void testAggiorno()
        {
            Console.WriteLine("Aggiorno indirizzo Cliente 1");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();

            //seleziono un cliente con uno specifico id (1)
            var query3 = from cli in albergoDB.Clienti
                         where cli.id == 1
                         select cli;

            Clienti upd = query3.First();
            upd.indirizzo = "via Morandi 34 Cattolica PE";
            albergoDB.SaveChanges();
            Console.ReadKey();
        }//fine test

        public static void testCancello()
        {
            Console.WriteLine("Cancello cliente Marco Bianchetti");
            AlbergoEntities albergoDB;
            albergoDB = new AlbergoEntities();
            var query4 = from cli in albergoDB.Clienti
                         where cli.nominativo == "Marco Bianchetti"
                         select cli;

            List<Clienti> toDel = query4.ToList();

            for (int i = 0; i < toDel.Count; i++)
                albergoDB.Clienti.Remove(toDel[i]);

            albergoDB.SaveChanges();
            Console.ReadKey();
        }//fine test
    }

}