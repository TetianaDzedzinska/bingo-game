namespace Bingo.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }

        public Cell[,] Cells { get; set; }

        public (int Rows, int Cols) Settings { get; set; }
    }
}