namespace Bingo.Web.Models
{
    public class Cell
    {
        public int Value { get; set; }
        public (int,int) Coordinates { get; set; }
        public bool IsSelected { get; set; }

        public Cell(int value)
        {
            Value = value;
            IsSelected = false;
        }
    }
}
