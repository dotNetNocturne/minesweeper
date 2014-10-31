using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper;

namespace MinesweeperPresentationLayer
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void SetBoardPresenter(BoardPresenter presenter)
        {
            dataGridView1.DataSource = presenter;
        }
    }
}
