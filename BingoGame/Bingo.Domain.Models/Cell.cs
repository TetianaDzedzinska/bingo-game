namespace Bingo.Domain.Models
{
    public class Cell
    {
        public int Value { get; set; }

        public bool IsMarked { get; set; }

        public bool IsWin { get; set; }

        public Cell(int value, bool isMarked)
        {
            Value = value;
            IsMarked = isMarked;
        }
    }
}