using System;

namespace RandonTest
{
	class Program
	{
		static Random random = new Random();
		static void Main(string[] args)
		{
			int intRandom = random.Next();
			Console.WriteLine(intRandom);

			int zeroToNine = random.Next(0, 10);
			Console.WriteLine(zeroToNine);

			int dieRoll = random.Next(1, 7);
			Console.WriteLine(dieRoll);

			double randomDouble = random.NextDouble();
			Console.WriteLine(randomDouble * 100);
			Console.WriteLine((float)randomDouble * 100F);
			Console.WriteLine((decimal)randomDouble * 100M);

			int zeroToOne = random.Next(2);
			bool coinFlip = Convert.ToBoolean(zeroToOne);
			Console.WriteLine(coinFlip);
		}
	}
}
