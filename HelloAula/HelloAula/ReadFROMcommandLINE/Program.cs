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

			Console.WriteLine("резултата А + Б = " + (a + b).ToString() + "\n");

			string
			test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";


			test += ", 5";

			Console.WriteLine("събиране с += :" + test + "\n");

			test = test.Replace(",", ";");
			Console.WriteLine("работа с Replace: " + test + "\n");

			Console.WriteLine("трети знак:  " + test.Split(';')[2]);



		}
	}
}
