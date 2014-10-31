using System.Security.Cryptography.X509Certificates;

namespace Minesweeper
{
    public interface IBoard
    {
        int Width { get; }
        int Height { get; }
        ICell GetCellAt(int x, int y);
        bool SetCell(int x, int y, ICell cell);
        void MarkMines();
        void SetCellBombs();
        ICell[,] CellMatrix { get; set; }
        int StepOnCell(int x, int y, ICell cell);
    }
}