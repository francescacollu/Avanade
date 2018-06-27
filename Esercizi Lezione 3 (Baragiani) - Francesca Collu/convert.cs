//Francesca Collu
//Lezione 3 - esercizio 3

using System;

namespace convert
{
	class convert
	{
		static void Main()
		{
			Console.WriteLine("Digita un numero intero e un numero reale da convertire rispettivamente in double e int: ");
			int l = int.Parse(Console.ReadLine());
			double d = double.Parse(Console.ReadLine());
				
			//conversione implicita int -> double
			double f = l;
			Console.WriteLine("Il numero inserito è stato convertito: {0}", f);
	
			int i;
			//conversione esplicita double -> int
			i = (int)d;
			Console.WriteLine("Il numero inserito è stato convertito: {0}", i);
		}
	}
}