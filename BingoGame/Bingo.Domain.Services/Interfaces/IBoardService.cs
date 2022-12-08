using Bingo.Domain.Models;
using System.Collections.Generic;

namespace Bingo.Domain.Services.Interfaces
{
    public interface IBoardService
    {
        public Board GenerateBoard(GameSettings settings);
    }
}
