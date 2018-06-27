using System;

namespace CiaoMondo
{
	class CiaoMondo
		{
			public static void Main (string[] args)
			{
				if(args.Length>0)
				{
					Console.WriteLine("Ciao{0}", args[0]);
				}
				else Console.WriteLine("Ciao, chi sei?");
			}
		}
}