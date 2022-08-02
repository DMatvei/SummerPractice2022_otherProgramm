using System;

namespace ElephantSwap
{
	class Program
	{
		static void Main(string[] args)
		{
			Elephant lloyd = new Elephant() { earSize = 40, name = "Lloyd" };
			Elephant lucinda = new Elephant() { name = "Lucinda", earSize = 33 };


			Console.WriteLine("Press 1 for Lloyd, 2 for Lucida, 3 for swap");
			while (true)
			{
				char keyChar = Console.ReadKey(true).KeyChar;
				Console.WriteLine("You pressed " + keyChar);
				if (keyChar == '1')
				{
					
					Console.WriteLine("Calling lloid.WhoAmI()");
					lloyd.WhoAmI();
				}
				else if (keyChar == '2')
				{
					
					Console.WriteLine("Calling lucinda.WhoAmI()");
					lucinda.WhoAmI();
				}
				else if (keyChar == '3')
				{
					

					Elephant temp = lloyd;
					lloyd = lucinda;
					lucinda = temp;

					Console.WriteLine("References has been swapped");
				}
				else if (keyChar == '4')
				{
					
					lloyd = lucinda;
					lloyd.earSize = 4321;
					lloyd.WhoAmI();
				}
				else if (keyChar == '5')
				{
					lucinda.SpeakTo(lloyd, "Hi, Lloyd");
				}
				else return;
				Console.WriteLine();
			}
		}
	}
}
