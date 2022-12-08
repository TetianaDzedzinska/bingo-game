using AutoMapper;
using Bingo.Domain.Models;
using Bingo.Web.Models;

namespace Bingo.Web.Mappers
{
    public class BoardViewMapper : Profile
    {
        public BoardViewMapper()
        {
            CreateMap<Board, BoardView>().ConvertUsing(typeof(BoardViewConverter));
        }
    }

    public class BoardViewConverter : ITypeConverter<Board, BoardView>
    {
        public BoardView Convert(Board source, BoardView destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new BoardView
            {
                Id = source.Id,
                Settings = source.Settings,
                IsWin = source.IsWin,
                Cells = source.Cells.MapToCellView()
            };
        }
    }
}
