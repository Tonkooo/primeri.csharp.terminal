using System;

namespace HelloAula
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//дефиниране на променливи

			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Модул 02 - примери";
			string program_version = "1.0";


			//събиране на числа
			a = 10;
			b = 5;

			sum = a + b;
			//данни за програмата
			Console.WriteLine( program_name );
			Console.WriteLine( "Версия: " + program_version + "\n\n");

			//писане в конзола
			Console.Write(a);
			Console.Write(" + ");
			Console.Write(b);
			Console.Write(" = ");
			Console.WriteLine(sum);

			//допълнителни оператори

			Console.WriteLine("\nизползване на +=");
			a += b;
			Console.WriteLine(a);

			Console.WriteLine("\nизползване на -=");
			a -= b;
			Console.WriteLine(a);

			Console.WriteLine("\nизползване на +=");
			a *= b;
			Console.WriteLine(a);

			Console.WriteLine("\nизползване на ++");
			a++;
			Console.WriteLine(a);

			Console.WriteLine("\nизползване на ++");
			a++;
			Console.WriteLine(a);

			Console.WriteLine("\nизползване на ++");
			a++;
			Console.WriteLine(a);

			Console.WriteLine("\nСтандартно делене");
			Console.WriteLine(a / b);

			Console.WriteLine("\nХващане на остатък");
			Console.WriteLine(a % b);









		}
	}
}
