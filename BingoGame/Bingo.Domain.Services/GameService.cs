using System;
using Bingo.Domain.Models;
using Bingo.Domain.Services.Interfaces;

namespace Bingo.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly IBoardService _boardService;

        public GameService(IBoardService boardService)
        {
            _boardService = boardService;
        }

        public Game StartGame(GameSettings settings)
        {
           return Game.CreateGame(settings);
        }

        public void AddPlayer(string playerName, GameSettings settings)
        {
            Game.Instance.SetPlayer(new Player
            {
                Id = Guid.NewGuid(),
                Name = playerName,
                Board = _boardService.GenerateBoard(settings)
            });
        }

        public int NextStep(Game game)
        {
            if(game.Status != GameStatus.Running)
            {
                return -1;
            }

            var nextNumber = game.PlayNextNumber();

            game.Player.Board.FindNumber(nextNumber);

            if (game.Player.Board.IsWin)
            {
                game.EndGame();
            }

            return nextNumber;
        }
    }
}
