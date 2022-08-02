using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoConsole
{
	class Guy
	{
		public string name;
		public int cash;

		/// <summary>
		/// Выводит значение моих полей name и cash
		/// </summary>
		public void WriteMyInfo()
		{
			Console.WriteLine("The " + name + " has " + cash + " bucks");
		}

		/// <summary>
		/// Выдаёт часть моих деняг, удаляя их из моего кармана(или выводит сообщение о том, что денег недостаточно
		/// </summary>
		/// <param name="amount">Выделяемая сумма</param>
		/// <returns>Сумма денег, взятая из кармана или 0, если денег недостаточно(или сумма не корректна)</returns>
		public int GiveCash(int amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine(name + " says: " + amount + " isn't a valid amount");
				return 0;
			}

			if (amount > cash)
			{
				Console.WriteLine(name + " says: " + "I don't have enough cash to give you " + amount);
				return 0;
			}

			cash -= amount;
			return amount;
		}


		/// <summary>
		/// Получает деньги, кладяя их в свой карман. (Или выводит сообщение на консоль, если сумма недействительна
		/// </summary>
		/// <param name="amount">Получаемая сумма</param>
		public void RecieveCash(int amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine(name + " says: " + amount + "isn't a amount I'll take");
			}
			else
			{
				cash += amount;
			}
		}




	}
}
