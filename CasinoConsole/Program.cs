using System;

namespace CasinoConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			CasinoPlay();
		}

		private static void CasinoPlay()
		{
			double odds = 0.75;
			Guy player = new Guy() { cash = 100, name = "Player" };

			CasinoWelcome(odds);
			StartGame(player, odds);
			
		}


/// <summary>
/// Начинает игру в казино
/// </summary>
/// <param name="player">Игрок</param>
/// <param name="odds">вероятность</param>
		private static void StartGame(Guy player, double odds)
		{
			while (true)
			{
				if (player.cash <= 0)
				{
					Console.WriteLine("The house always wins");
					return;
				}

				player.WriteMyInfo();
				Console.Write("How much you are want to bet: ");
				string howMuch = Console.ReadLine();

				if (howMuch == "") return;

				if (int.TryParse(howMuch, out int amount))
				{
					int pot = player.GiveCash(amount) * 2;
					if (ChekWin(odds))
					{
						Console.WriteLine("You win " + pot);
						player.RecieveCash(pot);
					}
					else
					{
						Console.WriteLine("Bad luck, you lose");
					}
					
				}

			}
		}


/// <summary>
/// проверка на выигрыш
/// </summary>
/// <param name="odds">порог выигрыша</param>
/// <returns>Возвращает true, если выиграл, и false - если проиграл </returns>
		private static bool ChekWin(double odds)
		{
			Random random = new Random();
			double chance = random.NextDouble();
			if (chance > odds) return true;
			else
			{
				return false;
			}
		}


/// <summary>
/// Выводит приветствие и текущую вероятность
/// </summary>
/// <param name="odds">Вероятность</param>
		private static void CasinoWelcome(double odds)
		{
			Console.WriteLine("Welcome to the casino. The odds are " + odds);
		}
	}
}
