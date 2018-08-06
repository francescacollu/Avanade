using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbergoEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            UpdatePrenotazioni.LetturaPrenotazioni();
            UpdatePrenotazioni.InserimentoPrenotazione();
            UpdatePrenotazioni.LetturaPrenotazioni();

        }

    }
}

/*
 * Al fine di preservare l'integrità dei dati, sarebbe utile implementare altri controlli di sicurezza:
 * bisognerebbe controllare che le date di check-in siano precedenti alle date di check-out;
 * bisognerebbe fare un controllo sulla esistenza nel DB del numero di camera inserita nella prenotazione,
 * in un modo simile a quello fatto per il controllo sull'idCliente;
 * bisognerebbe fare un controllo sulla disponibilità delle camere d'albergo nel periodo scelto dall'utente (per 
 * farlo, si deve verificare la condizione di non sovrapposizione dei periodi scelti dall'utente con i periodi in 
 * cui le stanze sono prenotate).
*/