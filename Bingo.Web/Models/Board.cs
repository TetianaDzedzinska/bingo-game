namespace Bingo.Web.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public (int Rows, int Cols) Settings { get; set; }
        public Cell[,] Cells { get; set; }
    }
}
