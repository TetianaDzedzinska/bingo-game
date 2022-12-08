namespace Bingo.Web.Models
{
    public class BoardView
    {
        public int Id { get; set; }
        public (int Rows, int Cols) Settings { get; set; }
        public CellView[,] Cells { get; set; }
        public bool IsWin { get; set; }
    }
}
