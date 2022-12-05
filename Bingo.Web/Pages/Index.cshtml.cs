using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bingo.Web.Models;

namespace Bingo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Board Board { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Board = new Board()
            {
                PlayerName = "Player 1 SuperMan",
                Settings = (5, 5),
                Cells = new Cell[5, 5]
                {
                    { new Cell(18), new Cell(5){IsSelected = true}, new Cell(25), new Cell(11), new Cell(7){IsSelected = true} },
                    { new Cell(6), new Cell(22), new Cell(25), new Cell(41), new Cell(7){IsSelected = true} },
                    { new Cell(45), new Cell(35), new Cell(25), new Cell(37), new Cell(27)},
                    { new Cell(20){IsSelected = true}, new Cell(51){IsSelected = true}, new Cell(25), new Cell(11), new Cell(33) },
                    { new Cell(1), new Cell(15), new Cell(10), new Cell(9), new Cell(43){IsSelected = true} }
                }
            };
        }
    }
}
