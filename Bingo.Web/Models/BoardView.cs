namespace Bingo.Web.Models
{
    public class BoardView
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public (int Rows, int Cols) Settings { get; set; }
        public Celliew[,] Cells { get; set; }
    }
}
