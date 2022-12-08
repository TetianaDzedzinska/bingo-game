using Bingo.Domain.Models;

namespace Bingo.Domain.Services.Interfaces
{
    public interface IGameService
    {
        public Game StartGame(GameSettings settings);
        public void AddPlayer(string playerName, GameSettings settings);

        public int NextStep(Game game);
    }
}
