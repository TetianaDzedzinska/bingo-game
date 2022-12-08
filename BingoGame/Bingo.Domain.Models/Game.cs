using System;
using System.Collections.Generic;

namespace Bingo.Domain.Models
{
    //used Singleton Pattern with Lazy approach to guarantee only one Game instance per application
    public class Game
    {
        public Guid Id { get; }
        public Player Player { get; private set; }
        public GameStatus Status { get; private set; }
        public List<int> AlreadyPlayedNumbers { get; } = new List<int>();
        public int MaxNumber { get; }

        private static Lazy<Game> Lazy(GameSettings settings) => new Lazy<Game>(() =>
        {
            Instance = new Game(settings);
            return Instance;
        });
        public static Game CreateGame(GameSettings settings) => Lazy(settings).Value;
        public static Game Instance { get; private set; }

        private Game(GameSettings settings)
        {
            Id = Guid.NewGuid();
            MaxNumber = settings.MaxNumber;
            Status = GameStatus.Started;
        }

        public void SetPlayer(Player player)
        {
            Player = player;
            Status = GameStatus.Running;
        }

        public int PlayNextNumber()
        {
            var rnd = new Random();
            int number;
            do
            {
                number = rnd.Next(1, MaxNumber + 1);
            } while (AlreadyPlayedNumbers.Contains(number));

            AlreadyPlayedNumbers.Add(number);

            return number;
        }

        public void EndGame()
        {
            Status = GameStatus.End;
        }
    }
}
