//Francesca Collu
//Lezione 3 - esercizio 1

using System;

namespace Welcome
{
	class Program
	{
		static void Main(string[] args)
		{
			string request1 = "Inserisci il tuo nome: ";
			Console.WriteLine(request1);
			string nome = Console.ReadLine();
			string request2 = "Inserisci il tuo cognome: ";
			Console.WriteLine(request2);
			string cognome = Console.ReadLine();
			
			if(nome.Length>0 && cognome.Length>0)
				{
					Console.WriteLine("Benvenuto/a {0} {1}", nome, cognome);
				}
				else
				{
					Console.WriteLine("Benvenuto gentile utente.");
				}
		}
	}
}