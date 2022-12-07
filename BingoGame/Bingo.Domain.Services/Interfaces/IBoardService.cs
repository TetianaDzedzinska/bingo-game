using Bingo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bingo.Domain.Services.Interfaces
{
    public interface IBoardService
    {
        public bool HasBoardWin(Board board, List<int> playedNumbers);
    }
}
