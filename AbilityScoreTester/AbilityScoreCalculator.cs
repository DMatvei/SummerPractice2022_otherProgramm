using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityScoreTester
{
	class AbilityScoreCalculator
	{
		public int rollResult = 14;
		public double divideBy = 1.75;
		public int addAmount = 2;
		public int minimum = 3;
		public int score;

		public void CalculateAbilityScore()
		{
			//результат броска делим на значение поля divideBy
			double divided = rollResult / divideBy;

			//addAmount добавляется к результату деления
			int added = addAmount + (int)divided;

			// если значение слишком мало, использовать значение по умолчанию
			if (added < minimum)
			{
				score = minimum;
			}
			else
			{
				score = added;
			}

		}


	}
}
