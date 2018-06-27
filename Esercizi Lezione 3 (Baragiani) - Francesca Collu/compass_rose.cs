//Francesca Collu
//Lezione 3 - esercizio 2

using System;

namespace CompassRose
{
	public class CompassRose
	{
		//enumerativo che simula la rosa dei venti
		enum compassRose {Nord, NordEst, Est, SudEst, Sud, SudOvest, Ovest, NordOvest};
		
		static void Main(string[] args)
		{
			int a = (int)compassRose.Nord;
			int b = (int)compassRose.Sud;
			
			//stampa dei numeri relativi a Nord e Sud
			Console.WriteLine("Nord = {0}", a);
			Console.WriteLine("Sud = {0}", b);
		}
	}
}