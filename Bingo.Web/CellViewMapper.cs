using Bingo.Domain.Models;
using Bingo.Web.Models;

namespace Bingo.Web
{
    public static class Extensions
    {
        public static Celliew[,] MapToCellView(this Cell[,] items)
        {
            int length0 = items.GetLength(0);
            int length1 = items.GetLength(1);

            var cells = new Celliew[length0, length1];

            for(int i = 0; i< length0; i++)
                for(int j = 0; j<length1; j++)
                {
                    cells[i, j] = new Celliew(items[i, j].Value);
                }

            return cells;
        }
    }
}
