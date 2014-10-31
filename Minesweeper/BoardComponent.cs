using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class BoardComponent
    {
        public void GenerateMines(IBoard board, int minesCount)
        {
            if (minesCount < 0)
                minesCount = 0;

            if (minesCount > board.Width*board.Height)
                throw new Exception("Mine number excedes total number of cells");
            var rand = new Random();

            var minesAdded = 0;
            while (minesAdded < minesCount)
            {
                var randX = rand.Next(board.Width);
                var randY = rand.Next(board.Height);

                var cell = board.GetCellAt(randX, randY);
                if (!cell.HasMine)
                {
                    minesAdded++;
                    cell.HasMine = true;
                }
            }

        }
    }
}
