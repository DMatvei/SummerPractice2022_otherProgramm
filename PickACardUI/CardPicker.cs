using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        
        /// <summary>
        /// Выбирает несколько карт и возвращает их
        /// </summary>
        /// <param name="numberOfCards">Количество выбираемых карт</param>
        /// <returns>Массив строк с названием карт</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spides";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Qeen";
            if (value == 13) return "King";

            return value.ToString();
        }
    }
}
