// Francesca Collu - settimana 9

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_and_coins
{
    class Program
    {
        static List<int> Confronto(Dice e1, Dice e2)
        {
            List<int> matches = new List<int>();
            foreach(int risultato1 in e1.Risultati)
            {
                foreach(int risultato2 in e2.Risultati)
                {
                    if (risultato1 == risultato2) { matches.Add(risultato2); }
                }
            }
            return matches;
        }

        static Dice GeneraEstrazione()
        {
            Dice dado = new Dice(90);

            for(int i=0; i<5; i++)
            {
                dado.Risultato();
            }

            return dado;
        }

        static int NumeroLanci()
        {
            Console.WriteLine("Inserire il numero dei lanci che si vuole effettuare: ");
            string userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }

        static void Main(string[] args)
        {
            ArrayList oggetti = new ArrayList(); // in realtà, poiché ho definito una classe astratta OggettoRandom, usare List e ArrayList si rivela del tutto equivalente.

            int a;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Scegliere se si vuole giocare al Lotto [A] o fare lanci liberi [B]: ");
                string inputL = Console.ReadLine();
                char sceltaL = Convert.ToChar(inputL);

                if (sceltaL == 'A')
                {
                    Hashtable estrazioni = new Hashtable();
                    Random numRandom = new Random();

                    estrazioni.Add("Cagliari", GeneraEstrazione());
                    estrazioni.Add("Milano", GeneraEstrazione());
                    estrazioni.Add("Roma", GeneraEstrazione());
                    estrazioni.Add("user", GeneraEstrazione());

                    Console.WriteLine("Scegliere la ruota su cui si vuole giocare:\n[C] per Cagliari, \n[M] per Milano, \n[R] per Roma ");
                    string inputR = Console.ReadLine();
                    char sceltaR = Convert.ToChar(inputR);
                    string ruotaScelta = "";

                    if (sceltaR == 'C') { ruotaScelta = "Cagliari"; }
                    else if (sceltaR == 'M') { ruotaScelta = "Milano"; }
                    else if (sceltaR == 'R') { ruotaScelta = "Roma"; }
                    else Console.WriteLine("La scelta non è valida.");

                    List<int> matches = Confronto(estrazioni[ruotaScelta] as Dice, estrazioni["user"] as Dice);

                    foreach(int i in matches)
                    {
                        Console.WriteLine("Hai indovinato il numero " + i);
                    }
                    if(matches.Count == 0)
                    {
                        Console.WriteLine("Non hai indovinato nessun numero.");
                    }
                }
                else if (sceltaL == 'B')
                {
                    Console.WriteLine("Scegliere se si vuole lanciare uno o più dadi [d] o una moneta [m]: ");
                    string userInput = Console.ReadLine();
                    char scelta = Convert.ToChar(userInput);

                    switch (scelta)
                    {
                        case 'd':
                            {
                                Console.WriteLine("Premere [L] per lanciare i dadi o [R] per il riepilogo dei lanci effettuati: ");
                                string inputD1 = Console.ReadLine();
                                char lancio_riep = Convert.ToChar(inputD1);

                                if (lancio_riep == 'L')
                                {
                                    bool rolling = true;
                                    while (rolling)
                                    {
                                        Console.WriteLine("Quanti dadi si vogliono lanciare?");
                                        string inputD = Console.ReadLine();
                                        int numD = Convert.ToInt32(inputD);
                                        if (numD == 0) { break; }

                                        for (int j = 0; j < numD; j++)
                                        {
                                            Console.WriteLine("Dado #" + (j + 1) + ":");
                                            Dice dado = Dice.LeggiDado();
                                            oggetti.Add(dado);

                                            int roll = NumeroLanci();
                                            for (int i = 0; i < roll; i++)
                                            {
                                                a = dado.Risultato();
                                            }

                                        }

                                        Console.WriteLine("Si vuole visualizzare il riepilogo? [s] o [n]");
                                        string inputD2 = Console.ReadLine();
                                        int rispostaD2 = Convert.ToChar(inputD2);
                                        if (rispostaD2 == 's')
                                        {
                                            Console.WriteLine("\nRiepilogo dei lanci effettuati:");
                                            foreach (OggettoRandom o in oggetti)
                                            {
                                                if (o is Dice) o.Print();
                                            }
                                        }
                                        else { break; }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nRiepilogo dei lanci effettuati: \n");
                                    foreach (OggettoRandom o in oggetti)
                                    {
                                        if (o is Dice) o.Print();
                                    }
                                }
                            }
                            break;

                        case 'm':
                            {
                                Console.WriteLine("Premere [L] per tirare la moneta o [R] per il riepilogo del lancio effettuato: ");
                                string inputM1 = Console.ReadLine();
                                char tiro_riep = Convert.ToChar(inputM1);

                                if (tiro_riep == 'L')
                                {
                                    Coins coin = new Coins();
                                    oggetti.Add(coin);
                                    int toss = NumeroLanci();
                                    for (int i = 0; i < toss; i++)
                                    {
                                        a = coin.Risultato();
                                    }
                                    Console.WriteLine("Si vuole visualizzare il riepilogo? [s] o [n]");
                                    string inputM2 = Console.ReadLine();
                                    int rispostaM2 = Convert.ToChar(inputM2);
                                    if (rispostaM2 == 's')
                                    {
                                        Console.WriteLine("\nRiepilogo:");
                                        foreach (OggettoRandom o in oggetti)
                                        {
                                            if (o is Coins) o.Print();
                                        }
                                    }
                                    else { break; }
                                }
                                else
                                {
                                    Console.WriteLine("\nRiepilogo:");
                                    foreach (OggettoRandom o in oggetti)
                                    {
                                        if (o is Coins) o.Print();
                                    }
                                }
                            }
                            break;
                    }

                    Console.WriteLine("Vuoi continuare? [s] per sì, [n] per no.");
                    userInput = Console.ReadLine();
                    char risposta = Convert.ToChar(userInput);
                    if (risposta == 's') { Console.Clear(); again = true; }
                    else
                    {
                        again = false;
                        Console.WriteLine("Vuoi vedere il riepilogo dei lanci totali effettuati?");
                        string riep = Console.ReadLine();
                        char rispFinale = Convert.ToChar(riep);
                        if (rispFinale == 's')
                        {
                            foreach (OggettoRandom o in oggetti)
                            {
                                o.Print();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Premere un tasto per uscire.");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
