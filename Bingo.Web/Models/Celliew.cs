namespace Bingo.Web.Models
{
    public class Celliew
    {
        public int Value { get; set; }
        public bool IsSelected { get; set; }

        public Celliew(int value)
        {
            Value = value;
            IsSelected = false;
        }
    }
}
