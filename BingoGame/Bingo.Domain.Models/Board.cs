namespace Bingo.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }

        public Cell[,] Cells { get; set; }

        public (int Rows, int Cols) Settings { get; set; }

        public bool IsWin {get;private set;} = false;

        public void FindNumber(int nextNumber)
        {
            foreach (Cell cell in Cells)
            {
                if(cell.Value == nextNumber)
                {
                    cell.IsMarked = true;
                    break;
                }
            }
            CheckWinnerLine();
        }

        private bool CheckWinnerLine()
        {
            bool hasBoardWin = false;

            //check horizontal line
            for (int i = 0; i < Settings.Rows; i++)
            {
                bool isSelectedRow = false;
                for (int j = 0; j < Settings.Cols; j++)
                {
                    if (Cells[i, j].IsMarked)
                    {
                        isSelectedRow = true;
                    }
                    else
                    {
                        isSelectedRow = false;
                        break;
                    }
                }
                hasBoardWin = isSelectedRow || hasBoardWin;
                if (hasBoardWin)
                {
                    for (int j = 0; j < Settings.Cols; j++)
                    {
                        Cells[i, j].IsWin = true;
                    }
                    IsWin = true;
                    return hasBoardWin;
                }
            }

            //check vertical line
            for (int i = 0; i < Settings.Cols; i++)
            {
                bool isSelectedRow = false;
                for (int j = 0; j < Settings.Rows; j++)
                {
                    if (Cells[j, i].IsMarked)
                    {
                        isSelectedRow = true;
                    }
                    else
                    {
                        isSelectedRow = false;
                        break;
                    }
                }
                hasBoardWin = isSelectedRow || hasBoardWin;
                if (hasBoardWin)
                {
                    for (int j = 0; j < Settings.Rows; j++)
                    {
                        Cells[j, i].IsWin = true;
                    }
                    IsWin = true;
                    return hasBoardWin;
                }
            }

            // check left-right diagonal
            bool isSelectedDiagonal = false;
            for (int i = 0; i < Settings.Cols; i++)
            {
                if (Cells[i, i].IsMarked)
                {
                    isSelectedDiagonal = true;
                }
                else
                {
                    isSelectedDiagonal = false;
                    break;
                }

            }
            hasBoardWin = isSelectedDiagonal || hasBoardWin;
            if (hasBoardWin)
            {
                for (int i = 0; i < Settings.Cols; i++)
                {
                    Cells[i, i].IsWin = true;
                }
                IsWin = true;
                return hasBoardWin;
            }


            // check right-left diagonal
            for (int i = 0; i < Settings.Cols; i++)
            {
                if (Cells[i, Settings.Cols - i - 1].IsMarked)
                {
                    isSelectedDiagonal = true;
                }
                else
                {
                    isSelectedDiagonal = false;
                    break;
                }

            }
            hasBoardWin = isSelectedDiagonal || hasBoardWin;

            if (hasBoardWin)
            {
                for (int i = 0; i < Settings.Cols; i++)
                {
                    Cells[i, Settings.Cols - i - 1].IsWin = true;
                }
                IsWin = true;
            }

            return hasBoardWin;
        }
    }
}