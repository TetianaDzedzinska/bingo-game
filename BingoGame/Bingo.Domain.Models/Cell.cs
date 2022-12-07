namespace Bingo.Domain.Models
{
    public class Cell
    {
        public int Value { get; set; }

        public bool IsSelected { get; set; }

        public Cell(int value, bool isSelected)
        {
            Value = value;
            IsSelected = isSelected;
        }
    }
}