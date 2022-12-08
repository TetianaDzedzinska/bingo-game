using Bingo.Domain.Models;
using Bingo.Web.Models;

namespace Bingo.Web.Mappers
{
    //Used to map Domain model Cell into CellView model. (later use AutoMapper)
    public static class CellViewMapper
    {
        public static CellView[,] MapToCellView(this Cell[,] boardCells)
        {
            var boardSize = boardCells.GetLength(0);

            var cells = new CellView[boardSize, boardSize];

            for (var i = 0; i < boardSize; i++)
            for (var j = 0; j < boardSize; j++)
            {
                cells[i, j] = new CellView(boardCells[i, j].Value)
                {
                    IsMarked = boardCells[i, j].IsMarked,
                    IsWin = boardCells[i, j].IsWin
                };
            }

            return cells;
        }
    }
}
