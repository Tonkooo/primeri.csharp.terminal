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

			//събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

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

			Console.WriteLine("Стандартно делене:  " + (9 / 4).ToString ()); //-> 2 
			Console.WriteLine("остатък от делене:  " + (9 % 4).ToString()); // -> 1




		}
	}
}
