using Bingo.Domain.Models;
using Bingo.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bingo.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly IBoardService _boardService;
        public Game CreateGame()
        {
            throw new NotImplementedException();
        }

        public Board GenerateBoard(int boardSize, int maxNumber)
        {
            var board = new Board()
            {
                Cells = new Cell[boardSize, boardSize],
                Settings = (boardSize, boardSize)
            };

            var rnd = new Random();
            var usedNumber = new List<int>(boardSize * boardSize);

            for (int i = 0; i < boardSize; i++)
                for (int j = 0; j < boardSize; j++)
                {
                    int number;
                    do
                    {
                        number = rnd.Next(1, maxNumber + 1);
                    } while (usedNumber.Contains(number));

                    usedNumber.Add(number);
                    board.Cells[i, j] = new Cell(number, false);
                }

            return board;
        }

        public int NextStep(Game game, int maxNumber)
        {
            int nextNumber = game.GetNextNumber(maxNumber);
            //todo: check number present at board
            var isWinner = _boardService.HasBoardWin(game.Player.Board, game.PlayedNumbers);

            return nextNumber;
        }
    }
}
