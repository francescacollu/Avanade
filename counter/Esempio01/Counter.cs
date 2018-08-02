using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio01
{
    class Counter
    {
        // attributi 
        private int threshold; // soglia max
        private int total=0; // totale presente

        // costruttore
        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        // getter soglia
        public int Threshold
        {
            get
            {
                return threshold;
            }
        }

        // aggiunta di un valore
        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                // invoco la soglia taggiunta e non passo dati evento
                OnThresholdReached(EventArgs.Empty);
            }
        }

        // soglia raggiunta
        protected virtual void OnThresholdReached(EventArgs e)
        {
            // aggiungo l'evento all'ascoltatore di eventi
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                // oggetto ed eventuali messaggi dell'evento
                handler(this, e);
            }
        }

        // evento soglia raggiunta
        public event EventHandler ThresholdReached;
    }
}

