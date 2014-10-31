using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public enum CellState
    {
        Normal,
        Flagged,
        Maybe,
        Visited
    }
}
