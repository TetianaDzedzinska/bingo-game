using Bingo.Domain.Models;

namespace Bingo.Domain.Services.Interfaces
{
    public interface IGameService
    {
        public Game CreateGame();

        public Board GenerateBoard(int boardSize, int maxNumber);

        public int NextStep(Game game, int maxNumber);
    }
}
