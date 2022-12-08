using AutoMapper;
using Bingo.Domain.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bingo.Web.Models;
using Bingo.Domain.Services.Interfaces;

namespace Bingo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public BoardView Board { get; set; }
        public Player Player { get; set; }

        public IndexModel(IGameService gameService, IMapper mapper)
        {
            _gameService = gameService;
            _mapper = mapper;
        }

        public void OnGet()
        {
            Player = Game.Instance.Player;
            Board = _mapper.Map<BoardView>(Game.Instance.Player.Board);
        }

        public void OnPostNextNumber()
        {
            Player = Game.Instance.Player;
            ViewData["SelectedNumber"] = _gameService.NextStep(Game.Instance);
            Board = _mapper.Map<BoardView>(Game.Instance.Player.Board);
        }
    }
}
