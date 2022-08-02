using System;

namespace AbilityScoreTester
{
	class Program
	{
		static void Main(string[] args)
		{
			AbilityScoreCalculator calculator = new AbilityScoreCalculator();
			while (true)
			{
				calculator.rollResult = ReadInt(calculator.rollResult, "Starting 4d6 roll");
				calculator.divideBy = ReadDouble(calculator.divideBy, "Divide by");
				calculator.addAmount = ReadInt(calculator.addAmount, "Add amount");
				calculator.minimum = ReadInt(calculator.minimum, "Minimum");
				calculator.CalculateAbilityScore();
				Console.WriteLine("Calculated ability score: " + calculator.score);
				Console.WriteLine("Press Q to quit, any other key to continue");
				char keyChar = Console.ReadKey(true).KeyChar;
				if ((keyChar == 'Q') || (keyChar == 'q')) return;
			}			
		}


		/// <summary>
		/// Выводит сообщение и читает double с консоли
		/// </summary>
		/// <param name="lastValue">Значение по умолчанию</param>
		/// <param name="v">сообщение пользователю</param>
		/// <returns>Прочитанное значение double или значение по умолчанию, если преообразование не удалось</returns>
		private static double ReadDouble(double lastValue, string v)
		{
			Console.Write(v + "[" + lastValue + "]: ");
			string inputValue = Console.ReadLine();
			if (double.TryParse(inputValue, out double value))
			{
				Console.WriteLine('\t' + "using value " + value);
				return value;
			}
			else
			{
				Console.WriteLine('\t' + "using default value " + lastValue);
				return lastValue;
			}
		}

		/// <summary>
		/// Выводит сообщение и читает int с консоли
		/// </summary>
		/// <param name="lastValue">Значение по умолчанию</param>
		/// <param name="v">Сообщение пользователю</param>
		/// <returns>Прочитанное значение int или значение по умолчание, если преобразование не удалось</returns>
		private static int ReadInt(int lastValue, string v)
		{
			Console.Write(v + "[" + lastValue + "]: ");
			string inputValue = Console.ReadLine();
			if (int.TryParse(inputValue, out int value))
			{
				Console.WriteLine('\t' + "using value " + value);
				return value;
			}
			else
			{
				Console.WriteLine('\t' + "using default value " + lastValue);
				return lastValue;
			}
		}
	}
}
