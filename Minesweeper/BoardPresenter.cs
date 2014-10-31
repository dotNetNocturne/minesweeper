using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class BoardPresenter
    {
        public BoardPresenter(IBoard board)
        {
            Board = board;
        }

        IBoard Board { get; set; }
        
        public int CellsCount { get; private set; }
    }


    public class BoardRow
    {

    }
}
