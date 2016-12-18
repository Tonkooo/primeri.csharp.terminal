using System;

namespace ReadFROMcommandLINE
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//дефиниране на променливи

			int a = 5, b = 0;

			//въвеждане на входни параметри
			Console.Write("моля въведете b:  ");
			b = Convert.ToInt32(Console.ReadLine());

			//печат на резултат

			Console.WriteLine("резултата А + Б = " + (a+b).ToString ()+ "\n\n\n");

		}
	}
}
