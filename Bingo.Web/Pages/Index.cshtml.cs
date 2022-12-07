using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bingo.Web.Models;
using Microsoft.Extensions.Options;
using Bingo.Domain.Services.Interfaces;

namespace Bingo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGameService _gameService;

        private readonly GameSettingsOptions _gameSettings;
        public BoardView Board { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IGameService gameService, IOptions<GameSettingsOptions> gameSettings)
        {
            _logger = logger;
            _gameSettings = gameSettings.Value;
            _gameService = gameService;
        }

        public void OnGet()
        {
            //todo: move to program
            //var game = _gameService.CreateGame();
            //_gameService.AddPlayer(game);
            Domain.Models.Board board = _gameService.GenerateBoard(_gameSettings.BoardSize, _gameSettings.MaxNumber);


            Board = new BoardView()
            {
                PlayerName = "Player 1 SuperMan",
                Settings = (_gameSettings.BoardSize, _gameSettings.BoardSize),
                Cells = board.Cells.MapToCellView()
            };
        }
    }
}
