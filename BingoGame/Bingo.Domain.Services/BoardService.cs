using System;
using Bingo.Domain.Models;
using Bingo.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace Bingo.Domain.Services
{
    public class BoardService : IBoardService
    {
        public Board GenerateBoard(GameSettings settings)
        {
            var board = new Board
            {
                Cells = new Cell[settings.BoardSize, settings.BoardSize],
                Settings = (settings.BoardSize, settings.BoardSize)
            };

            var rnd = new Random();
            var usedNumber = new List<int>(settings.BoardSize * settings.BoardSize);

            for (var i = 0; i < settings.BoardSize; i++)
            for (var j = 0; j < settings.BoardSize; j++)
            {
                int number;
                do
                {
                    number = rnd.Next(1, settings.MaxNumber + 1);
                } while (usedNumber.Contains(number));

                usedNumber.Add(number);
                board.Cells[i, j] = new Cell(number, false);
            }

            return board;
        }
    }
}
