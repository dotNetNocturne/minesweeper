using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Cell : ICell
    {
        private CellState state = CellState.Normal;

        public CellState State
        {
            get { return this.state; }
            private set { this.state = value; }
        }

        private bool hasMine = false;

        public bool HasMine
        {
            get { return this.hasMine; }
            set { this.hasMine = value; }
        }

        public bool CycleFlagState()
        {
            switch (this.state)
            {
                case CellState.Normal:
                    this.State = CellState.Flagged;
                    return true;
                case CellState.Flagged:
                    this.State = CellState.Maybe;
                    return true;
                case CellState.Maybe:
                    this.State = CellState.Normal;
                    return true;
            }
            return false;
        }
    }
}

