using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantSwap
{
	class Elephant
	{
		public string name;
		public int earSize;

		public void WhoAmI()
		{
			Console.WriteLine("My name is " + name);
			Console.WriteLine("My ear are " + earSize + " inches tall");
		}

		public void HearMessage(string message, Elephant whoSaidIt)
		{
			Console.WriteLine(name + " heard a message");
			Console.WriteLine(whoSaidIt.name + " said this: " + message);

		}

		public void SpeakTo(Elephant whoToTalkTo, string message)
		{
			whoToTalkTo.HearMessage(message, this);
		}
	}
}
