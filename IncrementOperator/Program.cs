using System;

namespace IncrementOperator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n1 = 0;
			int n2 = 0;
			int n3 = 0;

			Console.WriteLine($"{n1},  {n2},  {n3}");
			n1 = 5;
			Console.WriteLine($"{n1},  {n2},  {n3}");
			n2 = n1++;
			Console.WriteLine($"{n1},  {n2},  {n3}");
			n3 = ++n1;
			Console.WriteLine($"{n1},  {n2},  {n3}");



		}
	}
}
