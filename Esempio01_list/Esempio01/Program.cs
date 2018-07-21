using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio01
{
    public class Part : IEquatable<Part>
    {
        public string PartName;
        public int PartId;

        public override string ToString()
        {
            return "ID: " + PartId + "   Nome: " + PartName;
        }

        // override del meodo della superclasse Object
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }

        // Metodo che confronta due oggetti part per codice (da implementazione interfaccia)
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
       

    }

    public class Test
    {
        public static void Main()
        {
            // Creazione di una lista di pezzi di ricambio
            List<Part> parts = new List<Part>();

            // Aggiungo i pezzi di ricambio
            parts.Add(new Part() { PartName = "Boccola", PartId = 1234 });
            parts.Add(new Part() { PartName = "Collettore", PartId = 1334 });
            parts.Add(new Part() { PartName = "Cassetto", PartId = 1434 });
            parts.Add(new Part() { PartName = "Lamella", PartId = 1444 });
            parts.Add(new Part() { PartName = "Perno", PartId = 1534 });
            parts.Add(new Part() { PartName = "Cilindro", PartId = 1634 });

            // Invocazione implicita del metodo ToString
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart.ToString());
            }


            // confronto un codice per verificare se è presente nella lista dei pezzi di ricambio
            Console.WriteLine("\nE' presente il codice: (\"1734\"): {0}",parts.Contains(new Part { PartId = 1734, PartName = "" }));

            // Inserimento di un pezzo nella posizione 2 della lista ATTENZIONE: indice parte da 0
            Console.WriteLine("\nInserisco: (2, \"1834\")\n");
            parts.Insert(1, new Part() { PartName = "Biella", PartId = 1834 });


            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // visualizzo il pezzo in terza posizione ATTENZIONE: indice parte da 0
            Console.WriteLine("\nPezzo in posizione [3]: {0}", parts[2]);

            Console.WriteLine("\nRimuovo il pezzo di codice: (\"1534\")");

            // rimuovo il codice 1534 anche se il nome è diverso per via di Equals
            parts.Remove(new Part() { PartId = 1534, PartName = "PernoGrande" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nRimuovo il pezzo alla posizione: (3)");
            // ATTENZIONE la posizione 3 è l'indice 2
            parts.RemoveAt(2);

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.ReadKey();

        }
    }
}
