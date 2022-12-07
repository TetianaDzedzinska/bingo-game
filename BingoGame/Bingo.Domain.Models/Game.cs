using System;
using System.Collections.Generic;

namespace Bingo.Domain.Models
{
    public class Game
    {
        public int Id { get; set; }

        public Player Player { get; set; }

        public GameStatus GameStatus { get; set; }

        public List<int> PlayedNumbers { get; private set; }

        public int GetNextNumber(int maxNumber)
        {
            var rnd = new Random();
            int number;
            do
            {
                number = rnd.Next(1, maxNumber + 1);
            } while (PlayedNumbers.Contains(number));

            PlayedNumbers.Add(number);

            return number;
        }
    }
}
