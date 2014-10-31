using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Board : IBoard
    {
        public Board(int width, int height)
        {
            Width = width;
            Height = height;


            if (this.Width < 1)
                this.Width = 1;

            if (this.Height < 1)
                this.Height = 1;

            CellMatrix = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    CellMatrix [i,j] = new Cell();
                }
            }

        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public ICell[,] CellMatrix { get; set; }


        public ICell GetCellAt(int x, int y)
        {
            try
            {
                return CellMatrix[x,y];
            }
            catch (Exception)
            {
                return null;
            }
        }


        public void MarkMines()
        {

        }

        public void SetCellBombs()
        {
        }


        public bool SetCell(int x, int y, ICell cell)
        {
            try
            {
                CellMatrix[x, y] = cell;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public int StepOnCell(int x, int y, ICell cell)
        {
            if (cell.HasMine)
            {
                return -1;
            }

            int[] dx = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] dy = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };
            int count = 0;
            
            for (int idx = 0; idx < dx.Length; ++idx)
            {
                int nX = x + dx[idx];
                int nY = x + dy[idx];
                if (nX >= 0 && nX < Width && nY >= 0 && nY < Height)
                {
                    ICell neigh = GetCellAt(nX, nY);
                    if (neigh.HasMine)
                        count++;
                }

            }
            return count;
        }
    }

}