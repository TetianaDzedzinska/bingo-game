using Bingo.Domain.Models;
using Bingo.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace Bingo.Domain.Services
{
    public class BoardService : IBoardService
    {
        public bool HasBoardWin(Board board, List<int> playedNumbers)
        {
            bool hasBoardWin = false;

            //check horizontal line
            for (int i = 0; i < board.Settings.Rows; i++)
            {
                bool isSelectedRow = false;
                for (int j = 0; j < board.Settings.Cols; j++)
                {
                    if (board.Cells[i, j].IsSelected)
                    {
                        isSelectedRow = true;
                    }
                    else
                    {
                        isSelectedRow = false;
                        break;
                    }
                }
                hasBoardWin = isSelectedRow ? isSelectedRow : hasBoardWin;                
            }

            //check vertical line

            for (int i = 0; i < board.Settings.Cols; i++)
            {
                bool isSelectedRow = false;
                for (int j = 0; j < board.Settings.Rows; j++)
                {
                    if (board.Cells[i, j].IsSelected)
                    {
                        isSelectedRow = true;
                    }
                    else
                    {
                        isSelectedRow = false;
                        break;
                    }
                }
                hasBoardWin = isSelectedRow ? isSelectedRow : hasBoardWin;
            }
            // check diagonal


            return hasBoardWin;

        }
    }
}
