namespace Bingo.Web.Models
{
    public class CellView
    {
        public int Value { get; set; }
        public bool IsMarked { get; set; }
        public bool IsWin { get; set; }

        public CellView(int value)
        {
            Value = value;
            IsMarked = false;
            IsWin = false;
        }
    }
}
